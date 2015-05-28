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
        public int credit;
        [DataMember]
        public string name;
        public int playerId;
        public bool isMyTurn;
        public IChatCallback chatCallBack; 


        public User(int Credit, string Name, int PlayerId)
        {
            this.credit = Credit;
            this.name = Name;
            this.playerId = PlayerId;
        }


        public User(string username)
        {
            this.name = username;
        }
         
        
    }
}
