using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryMethod;

namespace FactoryMethod.Tests
{
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           // var volume =  new AquosCommand("VOLM", "30");
            var volume2 =  AquosCommand.Volume(30);
            
            Assert.IsTrue(volume.ToString()==volume2.ToString());
        }

        [TestMethod]
        public void PowerTest()
        {
           // var power = new AquosCommand("POWR", "0");

            var power2 = AquosCommand.Power(PowerSetting.Off);

            Assert.IsFalse(power.ToString() == power2.ToString());
        }
    }

   
}
