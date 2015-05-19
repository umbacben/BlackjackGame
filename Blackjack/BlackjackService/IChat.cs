using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BlackjackService
{
    [ServiceContract(Namespace = "ChatCallbacks", CallbackContract = typeof(IChatCallback))]
    public interface IChat
    {
        [OperationContract]
        void AddMessage(string playerName, string message);

        [OperationContract]
        bool Subscribe();

        [OperationContract]
        bool UnSubscribe();
    }
}
