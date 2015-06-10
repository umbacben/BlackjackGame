using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackjackService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class BlackJackGame : IBlackjackGame, IChat, IPortal
    {
        #region properites
        List<IBlackJackGameCallBack> blackjackCallbacks = new List<IBlackJackGameCallBack>();
        List<IChatCallback> chatCallbacks = new List<IChatCallback>();
        List<IPortalChatback> portalCallbacks = new List<IPortalChatback>();
        static Action<Game, Player> m_Event = delegate { };
        List<Game> GameList = new List<Game>();
        List<User> users = new List<User>();
        #endregion

        /// <summary>
        /// IBlackjack methods
        /// </summary>
        #region IBlackjackGame

        /// <summary>
        /// Hit method where the player gets another card and if that 
        /// player is bust will trigger bust event for that player
        /// </summary>
        /// <param name="game"></param>
        /// <param name="player"></param>
        public void Hit(Game game, Player player)
        {
                player.PlayHand.Add(game.GameDeck.getNextCard());
                
                bool temp = game.CalcVal(player);
                if (!temp)
                {
                    FireBustEvent(game, player);
                }
                this.UpdateGames(game);
        }

        /// <summary>
        /// Tells the system that that specific player is done
        /// taking cards for that round and updates the game
        /// </summary>
        /// <param name="game"></param>
        /// <param name="player"></param>
        public void Stay(Game game, Player player)
        {
            if (game.Player1 == player)
            {
                game.Player1.RoundDone = true;
            }
            else
            {
                game.Player2.RoundDone = true;
            }
            UpdateGames(game);
        }

        /// <summary>
        /// increases the pot and updates the game
        /// </summary>
        /// <param name="game"></param>
        /// <param name="mon"></param>
        public void IncreasePot(Game game, int mon)
        {
            game.Pot += mon;
            this.UpdateGames(game);
        }

        /// <summary>
        /// checks which player won if none went bust
        /// </summary>
        /// <param name="game"></param>
        public void DetermineWinner(Game game)
        {
            
            Player winner = null;
            if (game.Player1.HandVal>game.Player2.HandVal)
            {
                winner = game.Player1;
            }
            else if (game.Player1.HandVal < game.Player2.HandVal)
            {
                winner = game.Player2;
            }
            game.inRound = false;
            game.GameDeck = new Deck();
            this.UpdateGames(game);
        }


        /// <summary>
        /// the event is triggered if a player goes bust
        /// </summary>
        public void FireBustEvent(Game game, Player player)
        {
            m_Event(game, player);
        }

        /// <summary>
        /// player leaves the Game and then the system updates the game
        /// </summary>
        /// <param name="game"></param>
        /// <param name="leave"></param>
        public void LeaveGame(Game game, Player leave)
        {
            if (GameList.Find(x => x == game).inRound)
            {
                return;
            }
            else
            {
                if (GameList.Find(x => x == game).Player1 == leave)
                {
                    GameList.Find(x => x == game).Player1 = null;
                    if (this.checkGame(game))
                    {
                        this.UpdateGames(game);
                        return;
                    }
                    else
                    {
                        this.GameList.Remove(game);
                        return;
                    }
                }
                else
                {
                    GameList.Find(x => x == game).Player2 = null;
                    if (this.checkGame(game))
                    {
                        this.UpdateGames(game);
                        return;
                    }
                    else
                    {
                        this.GameList.Remove(game);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// checks whether or not therer are any players in the game,
        /// if so returns true, else returns false
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        private bool checkGame(Game game)
        {
            if (game.Player1 == null && game.Player2 == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// readys the player and checks if both players are ready to 
        /// </summary>
        /// <param name="game"></param>
        /// <param name="player"></param>
        public void ReadyPlayer(Game game, Player player)
        {
            if (player.UserName.Name == game.Player2.UserName.Name)
            {
                game.Player2.Ready = true;
            }
            else
            {
                game.Player1.Ready = true;
            }
            game.StartRound();
            this.UpdateGames(game);
        }

        /// <summary>
        /// subscribes the user to the blackjack callback
        /// </summary>
        public void SubscribeGame()
        {
            IBlackJackGameCallBack call = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
            blackjackCallbacks.Add(call);
        }

        /// <summary>
        /// calls the callback
        /// </summary>
        /// <param name="game"></param>
        private void UpdateGames(Game game)
        {
            blackjackCallbacks.ForEach(delegate(IBlackJackGameCallBack call)
            {
                if (((ICommunicationObject)call).State == CommunicationState.Opened)
                {
                    call.UpdateGame(game);
                }
            });
        }

        /// <summary>
        /// unsubscribes the user to the blackjack callback
        /// </summary>
        public void UnsubscribeGame()
        {
            try
            {
                IBlackJackGameCallBack call = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
                if (blackjackCallbacks.Contains(call))
                    blackjackCallbacks.Remove(call);
            }
            catch
            {
            }
        }
        #endregion

        /// <summary>
        /// IChat methods
        /// </summary>
        #region IChat

        /// <summary>
        /// subscribes the user to the chat callback
        /// </summary>
        public void SubscribeChat()
        {
            IChatCallback call = OperationContext.Current.GetCallbackChannel<IChatCallback>();
            chatCallbacks.Add(call);
        }

        /// <summary>
        /// utilizes the callbacks for the chat
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="message"></param>
        public void AddMessage(string playerName, string message)
        {
            chatCallbacks.ForEach(delegate(IChatCallback callback)
            {
                if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                {
                    callback.onMessageAdded(DateTime.Now, playerName, message);
                }
                else
                {
                    chatCallbacks.Remove(callback);
                }
            });
        }

        /// <summary>
        /// unsubscribes the user to the chat callback
        /// </summary>
        public void UnsubscribeChat()
        {
            try
            {
                IChatCallback callback = OperationContext.Current.GetCallbackChannel<IChatCallback>();
                if (chatCallbacks.Contains(callback))
                    chatCallbacks.Remove(callback);
            }
            catch
            {
            }
        }
        #endregion

        /// <summary>
        /// IPortal methods
        /// </summary>
        #region IPortal

        /// <summary>
        /// logs the person in if that username doesnt exist 
        /// and creates it as a person
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User Login(String user)
        {
            if (users.Exists(x=>x.Name==user))
            {
                return null;
            }
            User temp = new User(user);
            users.Add(temp);
            return temp;
        }

        /// <summary>
        /// registers the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User Register(String user)
        {
            if (users.Exists(x => x.Name == user))
            {
                return null;
            }
            User temp = new User(user);
            users.Add(temp);
            return temp;
        }

        /// <summary>
        /// logs the user out
        /// </summary>
        /// <param name="user"></param>
        public void Logout(User user)
        {
            users.Remove(user);
        }

        /// <summary>
        /// Joins the game and updates that game
        /// </summary>
        /// <param name="game"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool JoinGame(Game game, User user)
        {
            if (GameList.Exists(x => x.GameId == game.GameId))
            {
                if (game.Player2.UserName.Name!="")
                {
                    return false;
                }
                else
                {
                    Player temp = new Player(user);
                    game.Player2 = temp;
                    UpdateGames(game);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// creates the game and returns it to the creator
        /// </summary>
        /// <param name="user"></param>
        public Game CreateGame(User user)
        {
            Player temp = new Player(user);
            Game BJGame = new Game(temp);
            BJGame.Player2 = new Player(new User(""));
            GameList.Add(BJGame);
            return BJGame;
        }

        /// <summary>
        /// utilizes the callback to update the game list for everyone
        /// </summary>
        public void GetGameList()
        {
            portalCallbacks.ForEach(delegate(IPortalChatback call)
            {
                if (((ICommunicationObject)call).State == CommunicationState.Opened)
                {
                    call.UpdateGameList(this.GameList);
                }
            });
        }

        /// <summary>
        /// subscribes the user to the Portal callback
        /// </summary>
        public void SubscribePortal()
        {
            IPortalChatback call = OperationContext.Current.GetCallbackChannel<IPortalChatback>();
            portalCallbacks.Add(call);
        }

        /// <summary>
        /// unsubscribes the user to the Portal callback
        /// </summary>
        public void UnSubscribePortal()
        {
            try
            {
                IPortalChatback call = OperationContext.Current.GetCallbackChannel<IPortalChatback>();
                if (portalCallbacks.Contains(call))
                    portalCallbacks.Remove(call);
            }
            catch
            {
            }
        }
        #endregion
    }

}
