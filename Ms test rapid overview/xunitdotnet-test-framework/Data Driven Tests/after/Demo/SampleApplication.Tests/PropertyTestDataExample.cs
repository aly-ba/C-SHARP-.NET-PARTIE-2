using System;
using Xunit;
using Xunit.Extensions;

namespace SampleApplication.Tests
{
    public class PropertyTestDataExample
    {
        [Theory]
        [PropertyData("TestData", 
                    PropertyType=typeof(PropertyTestDataSource))]
        public void DataDriven(int number, bool expectedResult)
        {
            var sut = new NumberChecker();

            var result = sut.IsLessThanTen(number);

            Assert.Equal(expectedResult, result);
        }
    }
}