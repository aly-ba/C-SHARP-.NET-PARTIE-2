using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.observer_Pattern
{
    public  interface ISubject
    {
        void Register(IOberserver obserserver);
        void UnRegisert(IObserver observer);

        void Notify();
    }
}
