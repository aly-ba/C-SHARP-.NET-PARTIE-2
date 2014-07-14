using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpectingExceptions
{

    public class Hello
    {
        public string SayHello(string name)
        {
            if (name == null)
                throw new ArgumentNullException("params cannot be null!");

            return "Hello " + name;
        }

    }

}
