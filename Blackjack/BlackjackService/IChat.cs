using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BlackjackService
{
    [ServiceContract(Namespace = "BlackjackService", CallbackContract = typeof(IChatCallback))]
    public interface IChat
    {
        [OperationContract]
        void SubscribeChat();

        [OperationContract]
        void UnsubscribeChat();

        [OperationContract(IsOneWay = true)]
        void AddMessage(int id, string playerName, string message);
    }
    public interface IChatCallback
    {
        [OperationContract]
        void onMessageAdded(int gameId, DateTime dt, string playerName, string message);
    }
}
