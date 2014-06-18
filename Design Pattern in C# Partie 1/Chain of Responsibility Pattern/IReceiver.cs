using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Chain_of_Responsibility_Pattern
{
    public interface IReceiver
    {
        bool HandleMessage(Message message);
    }
}
