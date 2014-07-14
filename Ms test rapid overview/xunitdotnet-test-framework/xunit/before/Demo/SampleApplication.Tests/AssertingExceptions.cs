using System;
using Xunit;

namespace SampleApplication.Tests
{
    public class AssertingExceptions
    {

        [Fact]
        public void ExplicitNoExceptionAssertsAreNotRequired()
        {
            var sut = new Calculator();
            
            sut.Divide(10, 0);            
        }









        [Fact]
        public void SimpleUsage()
        {
            var sut = new Calculator();

            // Checks exact exception, not a derived exception type
            Assert.Throws<DivideByZeroException>(() =>
                                                 {
                                                     sut.Divide(10, 2);
                                                 });
        }



     






        [Fact]
        public void GettingExceptionDetails()
        {
            var sut = new Calculator();

            var ex = Assert.Throws<DivideByZeroException>(() =>
            {
                sut.Divide(10, 0);
            });

            Assert.Null(ex.InnerException);
        }
     

    }
}