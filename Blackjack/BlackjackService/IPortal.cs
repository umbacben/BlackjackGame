using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BlackjackService
{
    [ServiceContract]
    public interface IPortal
    {
        [OperationContract]
        User Login(String user);

        [OperationContract]
        bool Register(String user);

        [OperationContract]
        bool Logout(User user);

        [OperationContract]
        Player JoinGame(BlackJackGame game, User user);

        [OperationContract]
        Player CreateGame(User user);

        [OperationContract]
        List<BlackJackGame> GetGameList();
    }

}
