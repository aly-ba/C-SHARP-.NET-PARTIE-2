using System;
using NUnit.Framework;


namespace SampleApplication.Tests
{

    [TestFixture]
    public class AttributesNUnit
    {   
        [Test]
        public void SimpleTest()
        {
            Assert.IsTrue(true);
        }








        [Test]
        [Ignore("don't want to run this")]
        public void SkippedTest()
        {
            Assert.IsTrue(false);
        }











        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExpectedExceptionTest()
        {
            throw new InvalidOperationException();
        }

        [Test]        
        public void ExpectedExceptionInlineTest()
        {
            Assert.Catch<InvalidOperationException>(() =>
                                            {
                                                throw new InvalidOperationException();
                                            });
        }








        [TestCase(5, 6)]
        [TestCase(10, 20)]
        public void InlineDataDriven(int number1, int number2)
        {
            
        }










        [SetUp]
        public void PerTestSetup()
        {
            // Runs before each test is executed
        }

        [TearDown]
        public void PerTestTeardown()
        {
            // Runs after each test is executed
        }

    }
}