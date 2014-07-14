using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SampleApplication.Tests
{
    public class AssertingNotEqual
    {
        [Fact]
        public void SingleObjects()
        {
            Assert.NotEqual("hello", "hello");
        }










        [Fact]
        public void Collections()
        {
            IEnumerable<int> numbers1 = Enumerable.Range(1, 10);
            IEnumerable<int> numbers2 = Enumerable.Range(1, 10);

            Assert.NotEqual(numbers1, numbers2);
        }

        // Custom comparers also supported with Assert.NotEqual










        [Fact]
        public void NoPrecision()
        {
            var d1 = new Decimal(42.111);
            var d2 = new Decimal(42.112);

            // NotEqual doesn't support precision
            // Assert.NotEqual(d1, d2, 2); // Compile error
        }
    }
}