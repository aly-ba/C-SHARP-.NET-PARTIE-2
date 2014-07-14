using Ploeh.AutoFixture.Xunit;
using Xunit;
using Xunit.Extensions;

namespace SampleApplication.Tests
{
    public class AutoDataExample
    {   
        [Theory]
        [AutoData()]
        public void SingleAutoData(int number1, int number2)
        {
            var sut = new Calculator();

            var result = sut.Add(number1, number2);

            Assert.Equal(number1 + number2, result);
        }








        [Theory]
        [AutoData()]
        public void AutoDataTypes(string a, Person p)
        {            
            Assert.True(true);
        }










        [Theory]
        [InlineAutoData(42)]
        [InlineAutoData()]
        public void InlineAutoData(int number1, int number2)
        {
            var sut = new Calculator();

            var result = sut.Add(number1, number2);

            Assert.Equal(number1 + number2, result);
        }

    }
}