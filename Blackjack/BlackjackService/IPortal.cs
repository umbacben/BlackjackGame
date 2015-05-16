using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BlackjackService
{
    [ServiceContract]
    public interface IPortal
    {
        [OperationContract]
        public void SendMessage(string message);
        [OperationContract]
        public bool LogIn(string User, string Password);

    }
}
