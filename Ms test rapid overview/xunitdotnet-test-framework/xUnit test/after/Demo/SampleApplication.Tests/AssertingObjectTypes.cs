using Xunit;

namespace SampleApplication.Tests
{
    public class AssertingObjectTypes
    {
        [Fact]
        public void IsType()
        {
            int result = 42;

            Assert.IsType<string>(result);
        }


       






        [Fact]
        public void IsNotType()
        {
            int result = 42;

            Assert.IsNotType<string>(result);
        }









        [Fact]
        public void IsTypeWithDerivedClasses()
        {
            var d = new DerivedPerson();

            Assert.IsType<Person>(d);
        }









        [Fact]
        public void IsAssignableFrom()
        {
            var d = new DerivedPerson();

            Assert.IsAssignableFrom<Person>(d);
        }

    }
}