using DeadToadRoad.Fun.Extensions;
using Xunit;

namespace DeadToadRoad.Fun.Tests
{
    public class OptionTests
    {
        #region FlatMap

        [Fact]
        public void FlatMap_NoneIf()
        {
            var actual = Functions.None<string>()
                .FlatMap(Functions.If<string, int>(Functions.IsNotEmpty)(_ => 1));

            Assert.True(actual.IsNone());
            Assert.Equal(0, actual.GetUnsafe());
        }

        [Fact]
        public void FlatMap_SomeIfFalse()
        {
            var actual = Functions.Some(string.Empty)
                .FlatMap(Functions.If<string, int>(Functions.IsNotEmpty)(_ => 1));

            Assert.True(actual.IsNone());
            Assert.Equal(0, actual.GetUnsafe());
        }

        [Fact]
        public void FlatMap_SomeIfTrue()
        {
            var actual = Functions.Some("wut")
                .FlatMap(Functions.If<string, int>(Functions.IsNotEmpty)(_ => 1));

            Assert.True(actual.IsSome());
            Assert.Equal(1, actual.GetUnsafe());
        }

        #endregion
    }
}
