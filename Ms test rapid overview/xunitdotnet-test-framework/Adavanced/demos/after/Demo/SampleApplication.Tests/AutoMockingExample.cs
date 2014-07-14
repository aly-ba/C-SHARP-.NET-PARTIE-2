using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit;
using Xunit;
using Xunit.Extensions;

namespace SampleApplication.Tests
{
    public class AutoMockingExample
    {   
        [Fact]
        public void WithoutAutoMocking()
        {
            var mockEmailServer = new Mock<IEmailServer>();

            var sut = new PromoEmailSender(mockEmailServer.Object);

            sut.Send("Hi");

            mockEmailServer.Verify(x => x.Submit("Hi"), Times.Once);
        }









        [Fact]
        public void WithAutoMocking()
        {
            // Create a new AutoFixture fixture and enable Moq auto mocking
            var fixture = new Fixture().Customize(new AutoMoqCustomization());

            // Get a reference to the mock server that will be auto-supplied, 
            // so verifications can be made on it 
            var mockEmailServer = fixture.Freeze<Mock<IEmailServer>>();

            // Now using AutoFixture to create our SUT
            var sut = fixture.Create<PromoEmailSender>();
            
            sut.Send("Hi");

            mockEmailServer.Verify(x => x.Submit("Hi"), Times.Once);
        }












        [Theory] // Cannot use [Fact]
        [AutoFixtureMoqAutoDataAttribute]
        public void WithAutoMockingAttribute(
                                [Frozen] Mock<IEmailServer> mockEmailServer,
                                PromoEmailSender sut)
        {
            // No longer need to write and maintain "arrange" phase of test

            sut.Send("Hi");

            mockEmailServer.Verify(x => x.Submit("Hi"), Times.Once);
        }












        [Theory]
        [AutoFixtureMoqAutoDataAttribute]
        public void WithAutoMockingAttributeAndTestData(
                                [Frozen] Mock<IEmailServer> mockEmailServer,
                                PromoEmailSender sut, 
                                string message)
        {
            sut.Send(message);

            mockEmailServer.Verify(x => x.Submit(message), Times.Once);
        }
    }
}