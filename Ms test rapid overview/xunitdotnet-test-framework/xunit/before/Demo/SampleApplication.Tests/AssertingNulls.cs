using Xunit;

namespace SampleApplication.Tests
{
    public class AssertingNulls
    {
        [Fact]
        public void Null()
        {
            object result = null;

            Assert.Null(result);
        }
        
        [Fact]
        public void NotNull()
        {
            object result = null;

            Assert.NotNull(result);
        }

    }
}