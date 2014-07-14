namespace SampleApplication
{
    public class PersonWithEquals
    {
        

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        public string Name { get; set; }

        public override bool Equals(System.Object obj)
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

            // Return true if the fields match:
            return (p.Name == Name);
        }
    }
}
