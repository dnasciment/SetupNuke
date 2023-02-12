using Xunit;

namespace SetupNuke.Tests
{
    public class SetupNukeTests
    {
        [Fact]
        public void SetupNukeWillReturnHelloWorld()
        {
            var sut = new Main.SetupNuke();

            var actual = sut.ReturnHelloWorld();

            Assert.Equal("Hello World", actual);
        }
    }
}