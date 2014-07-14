using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpectingExceptions
{  
    [TestClass]
    public class ExpectExceptions
    {

        [ExpectedException(typeof(ArgumentNullException), "p fdgsfdgarams cannot be null!")]
        [TestMethod]
        public void TestCalc()
        {
            Hello h = new Hello();
            h.SayHello(null);

            //StringAssert.Contains("hello","hello");
        }
        
    }

}
