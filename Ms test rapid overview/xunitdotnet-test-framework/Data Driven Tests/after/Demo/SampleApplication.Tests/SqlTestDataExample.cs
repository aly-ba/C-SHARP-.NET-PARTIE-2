using Xunit;
using Xunit.Extensions;

namespace SampleApplication.Tests
{
    public class SqlTestDataExample
    {
        [Theory]
        [SqlServerData(@".\SQLEXPRESS",          // SQL Server name
                                    "XunitDemo",                   // database name
                                    "xUnitUser",                     // SQL login user name
                                    "demopassword",            // SQL login password
                                    "Select * from TestData" // select query
            )]
        public void DataDriven(int number, bool expectedResult)
        {
            var sut = new NumberChecker();

            var result = sut.IsLessThanTen(number);

            Assert.Equal(expectedResult, result);
        }
    }
}