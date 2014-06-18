using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Chain_of_Responsibility_Pattern
{
    public  class Logger : IReceiver
    {
        private IReceiver _nextReceiver;

        public Logger(IReceiver nextReceiver)
        {
            _nextReceiver = nextReceiver;
        }

        public bool HandleMessage(Message message)
        {
            if(message.Priority ==  MessagePriority.Normal)
            {
                Trace.WriteLine(message.Text + " :Logger processes it !!");
                return true;
            }
            else
            {
                if(_nextReceiver ! =null)
                    _nextReceiver.HandleMessage(message);
            }
            return false;
        }
    }
}
