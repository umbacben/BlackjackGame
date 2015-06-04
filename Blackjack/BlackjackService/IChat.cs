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
        void Subscribe();

        [OperationContract]
        void Unsubscribe();

        [OperationContract(IsOneWay = true)]
        void AddMessage(string playerName, string message);
    }
    public interface IChatCallback
    {
        [OperationContract]
        void onMessageAdded(DateTime dt, string playerName, string message);
    }
}
