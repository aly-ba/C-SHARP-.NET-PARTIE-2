using Xunit;

namespace SampleApplication.Tests
{
    [Trait("Category", "DataLayer")]
    public class GroupingTestsIntoCategories
    {
        [Fact]
        //[Trait("Category", "DataLayer")]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        //[Trait("Category", "DataLayer")]
        public void Test2()
        {
            Assert.True(true);
        }

        [Fact]
        //[Trait("Category", "PresentationLayer")]
        public void Test3()
        {
            Assert.True(true);
        }    

    }
}