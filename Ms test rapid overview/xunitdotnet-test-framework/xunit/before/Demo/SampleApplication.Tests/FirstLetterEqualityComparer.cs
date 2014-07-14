using System;
using System.Collections.Generic;

namespace SampleApplication.Tests
{
    public class FirstLetterEqualityComparer 
        : IEqualityComparer<PersonWithEquals>
    {
        public bool Equals(PersonWithEquals a, PersonWithEquals b)
        {
            return a.Name[0] == b.Name[0];
        }

        public int GetHashCode(PersonWithEquals obj)
        {
            throw new NotImplementedException();
        }
    }
}