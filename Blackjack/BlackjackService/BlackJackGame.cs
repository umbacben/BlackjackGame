using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BlackjackService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class BlackJackGame : IBlackjackGame
    {
        IBlackJackGameCallBack callback;
        IBustEvent subscriber;
        private int maxPlayers = 2;
        public int Pot { get; set; }
        public List<Player> Players { get; set; }
        private Deck GameDeck { get; set; }
        static Action m_Event = delegate { };

        public BlackJackGame(Player creator)
        {
            Pot = 0;
            Players = new List<Player>();
            Players.Add(creator);
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

        public List<Player> GetPlayers()
        {
            return Players;
        }

        public int GetPot()
        {
            return Pot;
        }

        public bool AddPlayer(Player player)
        {
            callback = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
            if (Players.Count != maxPlayers)
            {
                Players.Add(player);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void renextRound()
        {
            callback = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
            Pot = 0;
            GameDeck = new Deck();
        }

        public Player DetermineWinner()
        {
            callback = OperationContext.Current.GetCallbackChannel<IBlackJackGameCallBack>();
            Player winner = Players.First();
            for (int i = 1; i < Players.Count; i++)
            {
                Player temp = Players.ElementAt(i);
                if (temp.HandVal>winner.HandVal)
                {
                    winner = temp;
                }
            }
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

        //public User IsUser(string username, string password)
        //{
        //    User player = null;
        //    string sql = "SELECT password FROM User WHERE userName = '" + username + "'";
        //    MySqlCommand command = new MySqlCommand(sql, handler.connection);
        //    try
        //    {
        //        handler.connection.Open();
        //        MySqlDataReader reader = command.ExecuteReader();
        //        string pass = "";
        //        if (reader.Read())
        //        {
        //            pass = Convert.ToString(reader["password"]);

        //            player = new User(username);
        //        }

        //    }
        //    catch
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        handler.connection.Close();
        //    }
        //    return player;

        //}





        //bool ILogin.LogIn(string username, string password)
        //{
               
        //    User user = this.IsUser(username, password);
        //    if (user != null)
        //    {
        //        foreach (User item in UserList)
        //        {
        //            if (item.name == username)
        //            {
        //                return false;
        //            }
        //        }
        //        UserList.Add(user);
        //        return true;
        //    }
        //    return false;
        
        //}
    }
}
