using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Template_Method_Pattern
{
    public  class Machine
    {
        public  void Excecute()
        {
            Start();
            Produce();
            Stop();
        }

        protected virtual void Start()
        {
            Trace.WriteLine("Machine.Starting ...");
        }

        protected virtual void Produce()
        {
            Trace.WriteLine("Machine.Producing....");
        }

        protected virtual void Stop()
        {
            Trace.WriteLine("Machine.Stopping...");
        }
    }
}
