using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Chain_of_Responsibility_Pattern
{
    public class Emailer :IReceiver
    {
        private IReceiver _nextReceiver;

        public Emailer(IReceiver nextReceiver)
        {
            _nextReceiver = nextReceiver;

        }

        public bool HandleMesssag(Message message)
        {
            if(message.Priority == MessagePriority.High)
            {
                Trace.WriteLine(message.Text += " :Emailer processesed it!");
                return true;
            }
            else
            {
                if (_nextReceiver != null)
                    _nextReceiver.HandleMessage(message);
            }
            return false;
        }
    }
}
