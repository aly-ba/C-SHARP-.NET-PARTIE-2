using System;

namespace SampleApplication
{
    public class PersonWithEquals
    {
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var p = obj as PersonWithEquals;

            if (p == null)
            {
                return false;
            }

            return (p.Name == Name);
        }
    }
}