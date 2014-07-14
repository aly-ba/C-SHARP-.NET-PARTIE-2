using System.Collections.Generic;
using NUnit.Framework;


namespace SampleApplication.Tests
{
    [TestFixture]
    public class AssertsNUnit
    {   

        // These examples use the classic style of NUnit asserts
        // For more information on constraint assert style: www.nunit.org

        [Test]
        public void Booleans()
        {
            Assert.IsTrue(true);
            Assert.IsFalse(false);                       
        }












        [Test]
        public void Equality()
        {
            Assert.AreEqual(23, 23);
            Assert.AreNotEqual("Sarah", "Gentry");            
        }










        [Test]
        public void Nulls()
        {
            Assert.IsNull(null);
            Assert.IsNotNull("Sarah");
        }










        [Test]
        public void Sameness()
        {
            var a = new object();
            var b = a;
            var c = new object();

            Assert.AreSame(a, b);
            Assert.AreNotSame(a, c);
        }








        [Test]
        public void Collections()
        {
            var names = new List<string>();

            Assert.IsEmpty(names);

            names.Add("Sarah");

            Assert.IsNotEmpty(names);

            Assert.Contains("Sarah", names);
        }








        [Test]
        public void Fail()
        {            
            Assert.Fail("Forced failure");
        }

    }
}