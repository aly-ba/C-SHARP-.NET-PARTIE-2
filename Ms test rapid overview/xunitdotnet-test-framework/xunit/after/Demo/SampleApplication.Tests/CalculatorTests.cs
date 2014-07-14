using Xunit;

namespace SampleApplication.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAdd()
        {
            // Arrange
            var sut = new Calculator();

            // Act
            var result = sut.Add(5, 5);

            // Assert
            Assert.Equal(10, result);
        }
    }

    // R# < v8 http://xunitcontrib.codeplex.com/
}
