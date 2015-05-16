using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BlackjackService
{
    public class Portal:IPortal
    {
        string sql;

        public bool LogIn(string User, string Password)
        {
            return true;
        }
    }
}
