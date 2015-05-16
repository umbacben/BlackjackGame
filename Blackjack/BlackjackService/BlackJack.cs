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
    public class BlackJack : IBlackjack
    {
        private DBHandler handler = new DBHandler();
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public bool Login(string user, string password)
        {
            string sql = "SELECT password FROM User WHERE userName = '"+user+"'";
            MySqlCommand command = new MySqlCommand(sql, handler.connection);
            try
            {
                handler.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                string pass = "";
                if (reader.Read())
                {
                    pass = Convert.ToString(reader["password"]);
                }
                if (pass == password)
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
