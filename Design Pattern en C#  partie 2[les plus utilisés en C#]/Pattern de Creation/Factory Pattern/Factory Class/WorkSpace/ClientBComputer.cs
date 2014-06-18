using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class ClientBComputer : IComputer
    {
         public IComputer CreateComputer()
        {
            return new  ClientBComputer();
        }

        public ITablet CreateTablet()
        {
            return new ClientBTablet();
        }

        public ISmartPhone CreateSmartphone()
        {
            return new ClientBSmartPhone();
        }
    }
}
