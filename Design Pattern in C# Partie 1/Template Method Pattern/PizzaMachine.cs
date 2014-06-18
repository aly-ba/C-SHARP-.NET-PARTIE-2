using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Template_Method_Pattern
{
   public  class PizzaMachine : Machine
   {
       protected override void Produce()
       {
           Trace.WriteLine("PizzaMahcine.Producing ...");
       }

       protected class BuggerMachine : Machine
       {
           protected override void Produce()
           {
               Trace.WriteLine("BugergerMachine.Producing ...");
           }
       }
        
   }
}
