using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Chain_of_Responsibility_Pattern
{
    public  class Logic
    {
        public IReceiver Receiver;

        public void CreateMessage(Message message)
        {
            if(Receveir ! = null) 
                Receiver.HandleMessage(message);
        }

    }
}
