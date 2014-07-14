using System.Collections.Generic;
using Xunit;


namespace SampleApplication.Tests
{
    public class AssertsxUnit
    {   

        [Fact]
        public void Booleans()
        {
            Assert.True(true);
            Assert.False(false);                       
        }








        [Fact]
        public void Equality()
        {
            Assert.Equal(23, 23);
            Assert.NotEqual("Sarah", "Gentry");            
        }











        [Fact]
        public void Nulls()
        {
            Assert.Null(null);
            Assert.NotNull("Sarah");
        }












        [Fact]
        public void Sameness()
        {
            var a = new object();
            var b = a;
            var c = new object();

            Assert.Same(a, b);
            Assert.NotSame(a, c);
        }











        [Fact]
        public void Collections()
        {
            var names = new List<string>();

            Assert.Empty(names);

            names.Add("Sarah");

            Assert.NotEmpty(names);

            Assert.Contains("Sarah", names);
        }









        [Fact]
        public void Fail()
        {            
            Assert.True(false, "Forced failure");
        }

    }
}