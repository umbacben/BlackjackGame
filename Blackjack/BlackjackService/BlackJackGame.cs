using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackjackService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class BlackJackGame : IBlackjackGame
    {
        IBlackJackGameCallBack callback;
        IBustEvent subscriber;
        public int Pot { get; set; }
        public Player Host { get; set; }
        public Player Player2 { get; set; }
        private Deck GameDeck { get; set; }
        static Action m_Event = delegate { };
        public bool inRound = false;

        public BlackJackGame(Player creator)
        {
            Pot = 0;
            Host = creator;
            GameDeck = new Deck();
        }

        public bool Hit(Player player)
        {
            callback = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
            if (player.PlayHand.Count < 5)
            {
                player.PlayHand.Add(GameDeck.getNextCard());
                this.CalcVal(player);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Stay(Player player)
        {
            callback = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
            player.RoundDone = true;
            this.CalcVal(player);
        }

        public void IncreasePot(int mon)
        {
            callback = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
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
            callback = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
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
            callback = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
            Pot = 0;
            inRound = true;
            Host.PlayHand.Add(GameDeck.getNextCard());
            Host.PlayHand.Add(GameDeck.getNextCard());
            Player2.PlayHand.Add(GameDeck.getNextCard());
            Player2.PlayHand.Add(GameDeck.getNextCard());
        }

        public Player DetermineWinner()
        {
            callback = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
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
                if (play.PlayHand.Exists(x => x.Value == 11))
                {
                    play.HandVal = 0;
                    foreach (Card i in play.PlayHand)
                    {
                        if (i.Value == 11)
                        {
                            play.HandVal += 1;
                        }
                        else
                        {
                            play.HandVal += i.Value;
                        }
                    }
                    if (play.HandVal > 21)
                    {
                        FireBustEvent();
                    }
                }
                else
                {
                    FireBustEvent();
                }
            }
        }

        public void Subscribe()
        {
            subscriber = OperationContext.Current.GetCallbackChannel<IBustEvent>();
            m_Event += subscriber.Event;
        }

        public void FireBustEvent()
        {
            m_Event();
        }

        public bool LeaveGame(Player leave)
        {
            return true;
        }
    }
}
