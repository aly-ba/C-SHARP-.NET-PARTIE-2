using System;
using Xunit;

namespace SampleApplication.Tests
{
    public class RunningCodeBeforeAndAfterTests : IDisposable
    {
        // "The xUnit.net team feels that per-test setup and 
        // teardown creates difficult-to-follow and debug 
        // testing code, often causing unnecessary code to run 
        // before every single test is run."


        public RunningCodeBeforeAndAfterTests()
        {
            // per-test setup code goes here
        }

        [Fact]
        public void Test1()
        {            
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test3()
        {
            Assert.True(true);
        }

        public void Dispose()
        {
            // per-test teardown code goes here
        }
    }
}