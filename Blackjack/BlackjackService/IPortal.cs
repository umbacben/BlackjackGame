using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BlackjackService
{
    [ServiceContract(Namespace = "BlackjackService", CallbackContract = typeof(IPortalChatback))]
    public interface IPortal
    {
        [OperationContract]
        User Login(String user);

        [OperationContract]
        User Register(String user);

        [OperationContract]
        void Logout(User user);

        [OperationContract]
        bool JoinGame(Game game, User user);

        [OperationContract]
        Game CreateGame(User user);

        [OperationContract(IsOneWay = true)]
        void GetGameList();

        [OperationContract]
        void SubscribePortal();

        [OperationContract]
        void UnSubscribePortal();
    }
    public interface IPortalChatback
    {
        [OperationContract]
        void UpdateGameList(List<Game> gameList);
    }

}
