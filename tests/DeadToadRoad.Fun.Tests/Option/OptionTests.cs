using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class OptionTests
    {
        private const int DefaultExpected = 1;

        #region FlatMap

        [Fact]
        public void FlatMap_SomeSome()
        {
            var actual = Some("wut")
                .FlatMap(_ => Some(DefaultExpected));

            Assert.True(actual.IsSome);
            Assert.Equal(DefaultExpected, actual.GetUnsafe());
        }

        [Fact]
        public void FlatMap_SomeNone()
        {
            var actual = Some("wut")
                .FlatMap(_ => None<int>());

            Assert.True(actual.IsNone);
            Assert.Equal(default, actual.GetUnsafe());
        }

        [Fact]
        public void FlatMap_NoneSome()
        {
            var actual = None<string>()
                .FlatMap(_ => Some(DefaultExpected));

            Assert.True(actual.IsNone);
            Assert.Equal(default, actual.GetUnsafe());
        }

        [Fact]
        public void FlatMap_NoneNone()
        {
            var actual = None<string>()
                .FlatMap(_ => None<int>());

            Assert.True(actual.IsNone);
            Assert.Equal(default, actual.GetUnsafe());
        }

        #endregion

        #region GetOrElse

        [Fact]
        public void GetOrElse_Some()
        {
            var actual = Some("a").GetOrElse("b");
            Assert.Equal("a", actual);
        }

        [Fact]
        public void GetOrElse_None()
        {
            var actual = None<string>().GetOrElse("b");
            Assert.Equal("b", actual);
        }

        #endregion
    }
}
