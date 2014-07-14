using Xunit;

namespace SampleApplication.Tests
{    
    public class CustomCategoryTrait
    {
        [Fact]                
        [Category("DataLayer")]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        [Category("DataLayer")]
        [SmokeTest]
        public void Test2()
        {
            Assert.True(true);
        }

        [Fact]
        [SmokeTest]
        [Category("PresentationLayer")]
        public void Test3()
        {
            Assert.True(true);
        }    

    }
}