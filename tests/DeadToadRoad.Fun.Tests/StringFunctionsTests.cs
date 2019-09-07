using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class StringFunctionsTests
    {
        [Fact]
        public void IsWhiteSpace_WhiteSpace()
        {
            Assert.True(IsWhiteSpace("  \n "));
        }

        [Fact]
        public void IsWhiteSpace_Empty()
        {
            Assert.True(IsWhiteSpace(string.Empty));
        }

        [Fact]
        public void IsWhiteSpace_NonWhiteSpace()
        {
            Assert.False(IsWhiteSpace(" a "));
        }

        [Fact]
        public void IsWhiteSpace_Null()
        {
            Assert.False(IsWhiteSpace(null));
        }
    }
}
