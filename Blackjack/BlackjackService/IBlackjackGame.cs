using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackjackService
{
    [ServiceContract(Namespace = "BlackjackService", CallbackContract = typeof(IBlackJackGameCallBack))]
    public interface IBlackjackGame
    {
        [OperationContract(IsOneWay = true)]
        void Hit(Game game, Player player);

        [OperationContract(IsOneWay = true)]
        void Stay(Game game, Player player);

        [OperationContract(IsOneWay = true)]
        void IncreasePot(Game game, int mon);

        //[OperationContract]
        //Player DetermineWinner(Game game);

        [OperationContract]
        Player GetWinner(Game game);

        [OperationContract(IsOneWay = true)]
        void LeaveGame(Game game, Player leave);

        [OperationContract(IsOneWay = true)]
        void ReadyPlayer(Game game, Player player);

        [OperationContract(IsOneWay = true)]
        void SubscribeGame();

        [OperationContract(IsOneWay = true)]
        void UnsubscribeGame();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "BlackjackService.ContractType".

    [DataContract]
    public class Game
    {
        [DataMember]
        public int GameId { get; set; }

        [DataMember]
        public Player Player1 { get; set; }

        [DataMember]
        public Player Player2 { get; set; }

        [DataMember]
        public bool inRound { get; set; }

        [DataMember]
        public int Pot { get; set; }

        [DataMember]
        public Deck GameDeck { get; set; }

        public Game(Player creator)
        {
            Pot = 0;
            this.Player1 = creator;
            this.GameDeck = new Deck();
        }

        /// <summary>
        /// checks which player won if none went bust
        /// </summary>
        /// <param name="game"></param>
        public Player DetermineWinner()
        {
            Player winner = null;
            if (this.Player1.HandVal > this.Player2.HandVal && (!this.Player1.bust || !this.Player2.bust))
            {
                this.Player1.Money += this.Pot;
                winner = this.Player1;
            }
            else if (this.Player1.HandVal < this.Player2.HandVal && (!this.Player1.bust || !this.Player2.bust))
            {
                this.Player2.Money += this.Pot;
                winner = this.Player2;
            }
            else
            {
                this.Player1.Money += this.Pot / 2;
                this.Player2.Money += this.Pot / 2;
            }
            this.Pot = 0;
            this.inRound = false;
            this.GameDeck = new Deck();
            return winner;
        }

        public bool CalcVal(Player play)
        {
            if (play.UserName == Player1.UserName)
            {
                Player1 = play;
                Player1.HandVal = 0;
                foreach (Card i in Player1.PlayHand)
                {
                    Player1.HandVal += i.Value;
                }
                if (Player1.HandVal > 21)
                {
                    return false;
                }
                else return true;
            }
            else
            {
                Player2 = play;
                Player2.HandVal = 0;
                foreach (Card i in Player2.PlayHand)
                {
                    Player2.HandVal += i.Value;
                }
                if (Player2.HandVal > 21)
                {
                    return false;
                }
                else return true;
            }
        }

        public void StartRound()
        {
            if (this.Player1.Ready && this.Player2.Ready)
            {
            this.Pot = 0;
            this.inRound = true;
            this.Player1.PlayHand.Add(this.GameDeck.getNextCard());
            this.Player1.PlayHand.Add(this.GameDeck.getNextCard());
            this.Player2.PlayHand.Add(this.GameDeck.getNextCard());
            this.Player2.PlayHand.Add(this.GameDeck.getNextCard());
            }
        }
    }

    [DataContract]
    public class Card
    {
        [DataMember]
        public int Value { get; set; }

        [DataMember]
        public String PicLoc { get; set; }

        public Card(int val, String picloc)
        {
            Value = val;
            PicLoc = picloc;
        }
    }

    [DataContract]
    public class Deck
    {
        [DataMember]
        List<Card> CardList { get; set; }
        public Deck()
        {
            CardList = new List<Card>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    if (j<11)
                    {
                        CardList.Add(new Card(j,j.ToString()));
                    }
                    else if (j!=14)
                    {
                        CardList.Add(new Card(10,j.ToString()));
                    }
                    else
                    {
                        CardList.Add(new Card(11,j.ToString()));
                    }
                }
            }
        }

        /// <summary>
        /// Gets the next card of the deck
        /// </summary>
        /// <returns></returns>
        public Card getNextCard()
        {
            Random r = new Random();
            Card tmp = CardList.ElementAt(r.Next(CardList.Count));
            CardList.Remove(tmp);
            return tmp;
        }
    }

    [DataContract]
    public class Player
    {
        [DataMember]
        public List<Card> PlayHand { get; set; }

        [DataMember]
        public User UserName { get; set; }

        [DataMember]
        public int HandVal { get; set; }

        [DataMember]
        public bool RoundDone { get; set; }

        [DataMember]
        public int Money { get; set; }

        [DataMember]
        public bool Ready { get; set; }

        public bool bust { get; set; }

        public Player(User use)
        {
            UserName = use;
            PlayHand = new List<Card>();
            HandVal = 0;
            RoundDone = false;
            Ready = false;
            bust = false;
            Money = 1000;
        }

    }

    
    public interface IBlackJackGameCallBack
    {
        [OperationContract(IsOneWay = true)]
        void UpdateGame(Game game);
    }

    public interface IBustEvent
    {
        [OperationContract(IsOneWay = true)]
        void Event(Game game, Player player);
    }
}
