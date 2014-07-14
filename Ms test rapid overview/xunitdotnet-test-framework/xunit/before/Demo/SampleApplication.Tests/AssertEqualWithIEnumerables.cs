using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SampleApplication.Tests
{
    public class AssertEqualWithIEnumerables
    {    

        [Fact]
        public void ValueTypesEqual()
        {
            IEnumerable<int> numbers1 = Enumerable.Range(1, 10);
            IEnumerable<int> numbers2 = Enumerable.Range(1, 10);                       

            Assert.Equal(numbers1, numbers2);
        }








        [Fact]
        public void ValueTypesNotEqual()
        {
            IEnumerable<int> numbers1 = Enumerable.Range(1, 10);
            IEnumerable<int> numbers2 = Enumerable.Range(1, 11);

            Assert.Equal(numbers1, numbers2);
        }










        [Fact]
        public void ReferenceTypesNoOverridenEquals()
        {
            var people1 = new List<Person>
                          {
                              new Person {Name = "Sarah"},
                              new Person {Name = "Gentry"}
                          };

            var people2 = new List<Person>
                          {
                              new Person {Name = "Sarah"},
                              new Person {Name = "Gentry"}
                          };

            Assert.Equal(people1, people2);
        }










        [Fact]
        public void ReferencesTypesWithOverriddenEquals()
        {
            var people1 = new List<PersonWithEquals>
                          {
                              new PersonWithEquals {Name = "Sarah"},
                              new PersonWithEquals {Name = "Gentry"}
                          };

            var people2 = new List<PersonWithEquals>
                          {
                              new PersonWithEquals {Name = "Sarah"},
                              new PersonWithEquals {Name = "Gentry"}
                          };

            Assert.Equal(people1, people2); 
        }
        
    }
}