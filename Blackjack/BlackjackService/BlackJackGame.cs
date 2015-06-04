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
        IBlackJackGameCallBack blackjackCallback;
        List<IChatCallback> chatCallbacks = new List<IChatCallback>();
        public int Pot { get; set; }
        public Player Host { get; set; }
        public Player Player2 { get; set; }
        private Deck GameDeck { get; set; }
        static Action m_Event = delegate { };
        public bool inRound = false;
        List<BlackJackGame> GameList = new List<BlackJackGame>();
        List<User> users = new List<User>();

        public BlackJackGame()
        {

        }
        public BlackJackGame(Player creator)
        {
            Pot = 0;
            Host = creator;
            GameDeck = new Deck();
        }

        public bool Hit(Player player)
        {
            blackjackCallback = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
            if (player.PlayHand.Count < 5)
            {
                player.PlayHand.Add(GameDeck.getNextCard());
                this.CalcVal(player);
                blackjackCallback.UpdateGame(this);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Stay(Player player)
        {
            player.RoundDone = true;
            this.CalcVal(player);
            blackjackCallback.UpdateGame(this);
        }

        public void IncreasePot(int mon)
        {
            Pot += mon;
        }

        public Player GetOtherPlayer(Player current)
        {
            if (current == Host)
            {
                return Player2;
            }
            else
            {
                return Host;
            }
        }

        public int GetPot()
        {
            return Pot;
        }

        public bool AddPlayer(Player player)
        {
            if (Player2 == null)
            {
                Player2 = player;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StartRound()
        {
            Pot = 0;
            inRound = true;
            Host.PlayHand.Add(GameDeck.getNextCard());
            Host.PlayHand.Add(GameDeck.getNextCard());
            Player2.PlayHand.Add(GameDeck.getNextCard());
            Player2.PlayHand.Add(GameDeck.getNextCard());
            blackjackCallback.UpdateGame(this);
        }

        public Player DetermineWinner()
        {
            
            Player winner = null;
            if (Host.HandVal>Player2.HandVal)
            {
                winner = Host;
            }
            else if (Player2.HandVal >Host.HandVal)
            {
                winner = Player2;
            }
            inRound = false;
            GameDeck = new Deck();
            return winner;
        }

        private void CalcVal(Player play)
        {
            foreach (Card i in play.PlayHand)
            {
                play.HandVal += i.Value;
            }
            if (play.HandVal > 21)
            {
                FireBustEvent();
            }
        }

        public void FireBustEvent()
        {
            m_Event();
        }

        public bool LeaveGame(Player leave)
        {
            return true;
    
        }

        public void ReadyPlayer(Player player)
        {
            if (player == Player2)
            {
                Player2.Ready = true;
            }
            else
            {
                Host.Ready = true;
            }
            StartRound();
        }

        public void Subscribe()
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

        public void Unsubscribe()
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
            User temp = new User(user);
            users.Add(temp);
            return temp;
        }

        public bool Register(String user)
        {
            return true;
        }

        public bool Logout(User user)
        {
            return true;
        }

        public Player JoinGame(BlackJackGame game, User user)
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
            BlackJackGame Game = new BlackJackGame(temp);
            GameList.Add(Game);
            return temp;
        }

        public List<BlackJackGame> GetGameList()
        {
            return GameList;
        }

    }

}
