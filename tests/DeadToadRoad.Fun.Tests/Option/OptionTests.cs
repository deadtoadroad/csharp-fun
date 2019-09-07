using System;
using Xunit;
using static DeadToadRoad.Fun.OptionFunctions;

namespace DeadToadRoad.Fun.Tests
{
    public class OptionTests
    {
        private const int DefaultExpected = 1;
        private static readonly Func<string, Option<int>> DefaultMap = _ => Some(DefaultExpected);

        #region FlatMap

        [Fact]
        public void FlatMap_SomeSome()
        {
            var actual = Some("wut")
                .FlatMap(DefaultMap);

            Assert.True(actual.IsSome);
            Assert.Equal(DefaultExpected, actual.GetUnsafe());
        }

        [Fact]
        public void FlatMap_SomeNone()
        {
            var actual = Some(string.Empty)
                .FlatMap(_ => None<int>());

            Assert.True(actual.IsNone);
            Assert.Equal(default, actual.GetUnsafe());
        }

        [Fact]
        public void FlatMap_NoneSome()
        {
            var actual = None<string>()
                .FlatMap(DefaultMap);

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
