using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using BlackjackService;


namespace BlackjackService
{
    [ServiceContract(Namespace="LoginContract")]
    public interface ILogin
    {
        [OperationContract]
        bool LogIn(string username, string password);
    }
}
