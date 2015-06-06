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
        List<IBlackJackGameCallBack> blackjackCallbacks = new List<IBlackJackGameCallBack>();
        List<IChatCallback> chatCallbacks = new List<IChatCallback>();
        List<IPortalChatback> portalCallbacks = new List<IPortalChatback>();
        static Action m_Event = delegate { };
        List<Game> GameList = new List<Game>();
        List<User> users = new List<User>();

        public bool Hit(Game game, Player player)
        {
            if (player.PlayHand.Count < 5)
            {
                player.PlayHand.Add(game.GameDeck.getNextCard());
                
                bool temp = game.CalcVal(player);
                if (!temp)
                {
                    FireBustEvent();
                }
                this.UpdateGames(game);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Stay(Game game, Player player)
        {
            player.RoundDone = true;
            game.CalcVal(player);
            this.UpdateGames(game);
        }

        public void IncreasePot(Game game, int mon)
        {
            game.Pot += mon;
            this.UpdateGames(game);
        }

        public Player GetOtherPlayer(Game game, Player you)
        {
            if (game.Player1 == you)
            {
                return game.Player2;
            }
            else
            {
                return game.Player2;
            }
        }

        public bool AddPlayer(Game game, Player player)
        {
            if (game.Player2 == null)
            {
                game.Player2 = player;
                this.UpdateGames(game);
                return true;
            }
            else
            {
                return false;
            }
        }

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



        public void FireBustEvent()
        {
            m_Event();
        }

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

        public void ReadyPlayer(Game game, Player player)
        {
            if (player == game.Player2)
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

        public void SubscribeGame()
        {
            IBlackJackGameCallBack call = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
            blackjackCallbacks.Add(call);
        }

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

        public void SubscribeChat()
        {
            IChatCallback call = OperationContext.Current.GetCallbackChannel<IChatCallback>();
            chatCallbacks.Add(call);
        }

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

        public void Logout(User user)
        {
            users.Remove(user);
        }

        public Player JoinGame(Game game, User user)
        {
            if (GameList.Find(x=>x==game).Player2==null)
            {
                return null;
            }
            else
            {
                Player temp = new Player(user);
                GameList.Find(x => x == game).Player2 = temp;
                return temp;
            }
        }

        public Player CreateGame(User user)
        {
            Player temp = new Player(user);
            Game BJGame = new Game(temp);
            GameList.Add(BJGame);
            return temp;
        }

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

        public void SubscribePortal()
        {
            IPortalChatback call = OperationContext.Current.GetCallbackChannel<IPortalChatback>();
            portalCallbacks.Add(call);
        }

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
    }

}
