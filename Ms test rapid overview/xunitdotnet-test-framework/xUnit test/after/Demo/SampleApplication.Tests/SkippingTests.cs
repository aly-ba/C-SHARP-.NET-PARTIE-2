using Xunit;

namespace SampleApplication.Tests
{
    public class SkippingTests
    {
        [Fact]
        public void NonSkippedTest()
        {
            Assert.True(true);
        }    


        //[Fact(Skip="Don't want this to run")]
        //public void SkippedTest()
        //{
        //    Assert.True(true);
        //}
    }
}