using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BlackjackService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class Chat : IChat
    {
        private static readonly List<IChatCallback> subscribers = new List<IChatCallback>();

        public void AddMessage(string playerName, string message)
        {
            subscribers.ForEach(delegate(IChatCallback callback)
            {
                if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                {
                    callback.onMessageAdded(DateTime.Now, playerName, message);
                }
                else
                {
                    subscribers.Remove(callback);
                }
            });
        }

        public bool Subscribe()
        {
            try
            {
                IChatCallback chatCallBack = OperationContext.Current.GetCallbackChannel<IChatCallback>();
                if (!subscribers.Contains(chatCallBack))

                    subscribers.Add(chatCallBack);
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool UnSubscribe()
        {
            try
            {
                IChatCallback callback = OperationContext.Current.GetCallbackChannel<IChatCallback>();
                if (subscribers.Contains(callback))
                    subscribers.Remove(callback);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
