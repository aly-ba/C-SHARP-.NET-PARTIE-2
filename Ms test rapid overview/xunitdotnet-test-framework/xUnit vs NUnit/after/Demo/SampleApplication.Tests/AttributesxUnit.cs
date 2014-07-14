using System;
using Xunit;
using Xunit.Extensions;


namespace SampleApplication.Tests
{
 
    public class AttributesxUnit : IDisposable
    {   
        [Fact]
        public void SimpleTest()
        {
            Assert.True(true);
        }










        [Fact(Skip = "don't want to run this")]        
        public void SkippedTest()
        {
            Assert.True(true);
        }










        [Fact]        
        public void ExpectedExceptionTest()
        {
            Assert.Throws<InvalidOperationException>(() =>
                                                {
                                                    throw new InvalidOperationException();
                                                });
        }











        [Theory]        
        [InlineData(5, 6)]
        [InlineData(10, 20)]
        public void InlineDataDriven(int number1, int number2)
        {
            
        }









        public AttributesxUnit() // ctor
        {
            // Runs before each test is executed
        }

        
        public void Dispose()
        {
            // Runs after each test is executed
        }
    }
}