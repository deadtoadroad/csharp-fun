using System;
using DeadToadRoad.Fun.Extensions;
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
        public void If_True()
        {
            var actual = If(DefaultF)(true);
            Assert.True(actual.IsSome());
            Assert.Equal(DefaultExpected, actual.GetUnsafe());
        }

        [Fact]
        public void If_False()
        {
            var actual = If(DefaultF)(false);
            Assert.True(actual.IsNone());
            Assert.Equal(default, actual.GetUnsafe());
        }

        [Fact]
        public void IfNot_True()
        {
            var actual = IfNot(DefaultF)(true);
            Assert.True(actual.IsNone());
            Assert.Equal(default, actual.GetUnsafe());
        }

        [Fact]
        public void IfNot_False()
        {
            var actual = IfNot(DefaultF)(false);
            Assert.True(actual.IsSome());
            Assert.Equal(DefaultExpected, actual.GetUnsafe());
        }

        #endregion
    }
}
