using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.observer_Pattern
{
   public   interface IObserver
    {
       void ColorChanged(ConsoleColor newColor);
    }
}
