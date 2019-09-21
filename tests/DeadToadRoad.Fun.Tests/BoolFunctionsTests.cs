using System;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class BoolFunctionsTests
    {
        private const int DefaultExpected = 1;
        private static readonly Func<int> DefaultF = () => DefaultExpected;

        #region If

        [Fact]
        public void IfMap_True()
        {
            var actual = IfMap(DefaultF)(true);
            Assert.True(actual.IsSome);
            Assert.Equal(DefaultExpected, actual.GetUnsafe());
        }

        [Fact]
        public void IfMap_False()
        {
            var actual = IfMap(DefaultF)(false);
            Assert.True(actual.IsNone);
            Assert.Equal(default, actual.GetUnsafe());
        }

        [Fact]
        public void IfNotMap_True()
        {
            var actual = IfNotMap(DefaultF)(true);
            Assert.True(actual.IsNone);
            Assert.Equal(default, actual.GetUnsafe());
        }

        [Fact]
        public void IfNotMap_False()
        {
            var actual = IfNotMap(DefaultF)(false);
            Assert.True(actual.IsSome);
            Assert.Equal(DefaultExpected, actual.GetUnsafe());
        }

        #endregion
    }
}
