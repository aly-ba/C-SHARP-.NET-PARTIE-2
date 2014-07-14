using Xunit;
using Xunit.Extensions;

namespace SampleApplication.Tests
{
    public class ExcelTestDataExample
    {
        [Theory]
        [ExcelData("SampleData.xls", "Select * from TestData")]
        public void DataDriven(int number, bool expectedResult)
        {
            var sut = new NumberChecker();

            var result = sut.IsLessThanTen(number);

            Assert.Equal(expectedResult, result);
        }
    }
}