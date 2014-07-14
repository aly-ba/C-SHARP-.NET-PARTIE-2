using Xunit;
using Xunit.Extensions;

namespace SampleApplication.Tests
{    
    public class CustomDataAttributeExample
    {
        [Theory]        
        [RangeData(20,11)]
        public void OneToTen(int number)
        {
            Assert.True(true);
        }

    }
}