using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit;

namespace SampleApplication.Tests
{
    public class AutoFixtureMoqAutoDataAttribute : AutoDataAttribute 
    {
        public AutoFixtureMoqAutoDataAttribute() :
            base(new Fixture().Customize(new AutoMoqCustomization())) 
        {            
        }
    }
}