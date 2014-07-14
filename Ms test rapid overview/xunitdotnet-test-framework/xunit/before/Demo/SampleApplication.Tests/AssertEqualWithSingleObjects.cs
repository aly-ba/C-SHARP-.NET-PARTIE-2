using Xunit;

namespace SampleApplication.Tests
{
    public class AssertEqualWithSingleObjects
    {
        [Fact]
        public void ComparingValueTypes()
        {
            var sut = new Calculator();

            var result = sut.Add(10, 5);

            Assert.Equal(15, result);
        }



        [Fact]
        public void ComparingReferenceTypes()
        {
            var p1 = new Person {Name = "Sarah"};
            var p2 = new Person {Name = "Sarah"};

            Assert.Equal(p1, p2); // Fail - different references
            
            var p3 = p1;

            Assert.Equal(p1, p3); // Pass - same reference
        }


        [Fact]
        public void ComparingReferenceTypesWithOverriddenEquals()
        {
            var p1 = new PersonWithEquals { Name = "Sarah" };
            var p2 = new PersonWithEquals { Name = "Sarah" };

            Assert.Equal(p1, p2); 
        }


        [Fact]
        public void CustomIEqualityComparer()
        {
            var p1 = new PersonWithEquals { Name = "Sarah" };
            var p2 = new PersonWithEquals { Name = "Simon" };

            // Using an explicit IEqualityComparer works in place of PersonWithEquals.Equals
            Assert.Equal(p1, p2, new FirstLetterEqualityComparer()); 
        }

    }
}