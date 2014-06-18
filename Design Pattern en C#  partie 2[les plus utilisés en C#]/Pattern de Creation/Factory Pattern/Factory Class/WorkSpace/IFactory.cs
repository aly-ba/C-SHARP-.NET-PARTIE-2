using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public interface IFactory
    {
        IComputer CreateComputer();
        ITablet CreateTablet();
        ISmartPhone CreateSmartPhone();
    }
}
