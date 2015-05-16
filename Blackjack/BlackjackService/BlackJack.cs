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
    public class BlackJack : IBlackjack, IPortal
    {
        private DBHandler handler = new DBHandler();
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public bool Login(string user, string password)
        {
            string sql = "SELECT * FROM User WHERE userName = '"+user+"' AND password = '"+password+"'";
            MySqlCommand command = new MySqlCommand(sql, handler.connection);
            try
            {
                handler.connection.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                handler.connection.Close();
            }
        }
    }
}
