using Xunit;

namespace SampleApplication.Tests
{
    class CategoryAttribute : TraitAttribute
    {
        public CategoryAttribute(string categoryName) 
            : base("Category", categoryName)
        {
        }
    }
}
