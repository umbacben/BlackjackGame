using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using BlackjackService;

namespace BlackjackService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class BlackJack : IBlackjack,IChat,ILogin
    {
        private DBHandler handler = new DBHandler();
        private List<Player> playerList;
        private static readonly List<IChatCallback> subscribers = new List<IChatCallback>();

        public BlackJack()
        {
            playerList = new List<Player>();
            handler = new DBHandler();
        }
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Player IsUser(string username, string password)
        {
            Player player = null;
            string sql = "SELECT password FROM User WHERE userName = '" + username + "'";
            MySqlCommand command = new MySqlCommand(sql, handler.connection);
            try
            {
                handler.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                string pass = "";
                if (reader.Read())
                {
                    pass = Convert.ToString(reader["password"]);

                    player = new Player(username);
                }

            }
            catch
            {

                throw;
            }
            finally
            {
                handler.connection.Close();
            }
            return player;

        }

        public void AddMessage(string playerName, string message)
        {
            subscribers.ForEach(delegate(IChatCallback callback)
            {
                if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                {
                    callback.onMessageAdded(DateTime.Now, playerName, message);
                }
                else
                {
                    subscribers.Remove(callback);
                }
            });
        }

        public bool Subscribe()
        {
            try
            {
                IChatCallback chatCallBack = OperationContext.Current.GetCallbackChannel<IChatCallback>();
                if (!subscribers.Contains(chatCallBack))

                    subscribers.Add(chatCallBack);
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool UnSubscribe()
        {
            try
            {
                IChatCallback callback = OperationContext.Current.GetCallbackChannel<IChatCallback>();
                if (subscribers.Contains(callback))
                    subscribers.Remove(callback);
                return true;
            }
            catch
            {
                return false;
            }
        }



        bool ILogin.LogIn(string username, string password)
        {
               
            Player player = this.IsUser(username, password);
            if (player != null)
            {
                foreach (Player item in playerList)
                {
                    if (item.name == username)
                    {
                        return false;
                    }
                }
                playerList.Add(player);
                return true;
            }
            return false;
        
        }
    }
}
