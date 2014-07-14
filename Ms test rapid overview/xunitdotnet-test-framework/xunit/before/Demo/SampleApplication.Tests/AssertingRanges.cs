using Xunit;

namespace SampleApplication.Tests
{
    public class AssertingRanges
    {
        [Fact]
        public void InRange()
        {
            var result = 42;

            Assert.InRange(result, 42, 50);

            // Assert.InRange(result, 43, 50);
        }

        






        [Fact]
        public void NotInRange()
        {
            var result = 43;

            Assert.NotInRange(result, 43, 50);
        }

    }
}