using Xunit;

namespace SampleApplication.Tests
{
    public class AssertingBooleans
    {
        [Fact]
        public void AssertTrue()
        {
            var result = true;

            Assert.True(result);
        }












        [Fact]
        public void AssertFalse()
        {
            var result = false;

            Assert.False(result);
        }













        [Fact]
        public void BadUse()
        {
            var a = "Sarah";
            var b = "Gentry";

            Assert.True(a == b);             
        }











        [Fact]
        public void WithMessage()
        {
            var result = false;

            Assert.True(result, "this is a custom message");             
        }

    }
}