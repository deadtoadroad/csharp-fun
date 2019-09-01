using System;
using DeadToadRoad.Fun.Extensions;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class OptionTests
    {
        private const int DefaultExpected = 1;
        private static readonly Func<string, int> DefaultMap = _ => DefaultExpected;

        #region FlatMap

        [Fact]
        public void FlatMap_SomeIfTrue()
        {
            var actual = Some("wut")
                .FlatMap(If<string, int>(IsNotEmpty)(DefaultMap));

            Assert.True(actual.IsSome());
            Assert.Equal(DefaultExpected, actual.GetUnsafe());
        }

        [Fact]
        public void FlatMap_SomeIfFalse()
        {
            var actual = Some(string.Empty)
                .FlatMap(If<string, int>(IsNotEmpty)(DefaultMap));

            Assert.True(actual.IsNone());
            Assert.Equal(default, actual.GetUnsafe());
        }

        [Fact]
        public void FlatMap_NoneIf()
        {
            var actual = None<string>()
                .FlatMap(If<string, int>(IsNotEmpty)(DefaultMap));

            Assert.True(actual.IsNone());
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
