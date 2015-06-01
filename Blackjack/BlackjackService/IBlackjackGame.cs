using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackjackService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "BlackjackService", CallbackContract = typeof(IBlackJackGameCallBack))]
    public interface IBlackjackGame
    {
        [OperationContract]
        bool Hit(Player player);

        [OperationContract]
        void Stay(Player player);

        [OperationContract]
        void IncreasePot(int mon);

        [OperationContract]
        Player GetOtherPlayer(Player current);

        [OperationContract]
        int GetPot();

        [OperationContract]
        bool AddPlayer(Player player);

        [OperationContract]
        void StartRound();

        [OperationContract]
        Player DetermineWinner();

        [OperationContract]
        bool LeaveGame(Player leave);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "BlackjackService.ContractType".

    [DataContract]
    public class Card
    {
        [DataMember]
        public int Value { get; set; }

        public Card(int val)
        {
            Value = val;
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
        public bool Ready { get; set; }

        public Player(User use)
        {
            //UserName = use;
            //PlayHand = new List<Card>();
            HandVal = 0;
            RoundDone = false;
            Ready = false;
        }

    }

    public interface IBlackJackGameCallBack
    {
        [OperationContract]
        void OnValueChange(Player player);
    }

    public interface IBustEvent
    {
        [OperationContract(IsOneWay = true)]
        void Event();
    }
}
