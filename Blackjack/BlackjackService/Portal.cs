using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BlackjackService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class Portal:IPortal
    {
        List<BlackJackGame> GameList { get; set; }
        List<User> users { get; set; }


        public bool Login(String user)
        {
            if (users.Exists(x => x.Name == user))
            {
                return false;
            }
            else
            {
                users.Add(new User(user));
                return true;
            }
        }

        public bool Register(String user)
        {
            return true;
        }

        public bool Logout(User user)
        {
            return true;
        }

        public bool JoinGame(BlackJackGame game)
        {
            return true;
        }

        public void CreateGame()
        {

        }
    }
}
