using System;
using Xunit;

namespace SampleApplication.Tests
{
    public class AssertEqualWithDecimals
    {
        [Fact]
        public void DecimalExact()
        {
            var d1 = new Decimal(24);
            var d2 = new Decimal(24);

            Assert.Equal(d1, d2);
        }








        [Fact]
        public void DecimalWithPrecision()
        {
            var d1 = new Decimal(24.111);
            var d2 = new Decimal(24.112);

            // Pass - first 2 decimal places are equal
            Assert.Equal(d1, d2, 2);

            // Fail - third decimal place is not equal
            Assert.Equal(d1, d2, 3); 
        }

        // Also overloads of Assert.Equal that work 
        // with doubles and precision
    }
}