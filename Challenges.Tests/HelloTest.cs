using Challenges;
using Xunit;

namespace Challenges.Tests
{
    public class Hello_WorldShould
    {
        [Fact]
        public void HelloWorld_ReturnWorld()
        {
            var hello = new Hello();
            Assert.Equal(hello.World(), "World");
        }
    }
}