using Xunit;

namespace SampleApplication.Tests
{
    class SmokeTestAttribute : TraitAttribute
    {
        public SmokeTestAttribute()
            : base("Category", "SmokeTest")
        {
        }
    }
}
