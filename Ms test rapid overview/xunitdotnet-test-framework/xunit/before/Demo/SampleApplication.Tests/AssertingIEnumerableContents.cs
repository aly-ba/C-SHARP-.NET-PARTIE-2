using Xunit;

namespace SampleApplication.Tests
{
    public class AssertingIEnumerableContents
    {
        [Fact]
        public void Contains()
        {
            var names = new[] {"Sarah", "Amrit"};

            Assert.Contains("Sarah", names);
            
            // Assert.Contains("Gentry", names);
        }








        [Fact]
        public void DoesNotContain()
        {
            var names = new[] { "Sarah", "Amrit" };

            Assert.DoesNotContain("Sarah", names);            
        }








        [Fact]
        public void Empty()
        {
            var names = new[] { "Sarah", "Amrit" };

            Assert.Empty(names);
        }

    }
}