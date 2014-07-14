using Xunit;
using Xunit.Extensions;

namespace SampleApplication.Tests
{
    public class InlineTestDataExample
    {   
        [Theory]
        [InlineData(9, true)]
        [InlineData(10, false)]
        [InlineData(11, false)]
        [InlineData(-1, true)]
        public void DataDriven(int number, bool expectedResult)
        {
            var sut = new NumberChecker();

            var result = sut.IsLessThanTen(number);

            Assert.Equal(expectedResult, result);
        }



    }
}