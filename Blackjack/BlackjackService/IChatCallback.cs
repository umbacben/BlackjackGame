﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using BlackjackService;

namespace BlackjackService
{
    public interface IChatCallback
    {
        [OperationContract(IsOneWay=true)]
        void onMessageAdded(DateTime dt,string playerName, string message);

    }
}