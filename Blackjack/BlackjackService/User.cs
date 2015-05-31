using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackService;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace BlackjackService
{
    public class User
    {
        [DataMember]
        public string Name { get; set; }


        public User(string username)
        {
            this.Name = username;
        }
         
        
    }
}
