using System;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class BoolFunctionsTests
    {
        private const int DefaultExpected = 1;
        private static readonly Func<int> DefaultMap = () => DefaultExpected;

        #region If

        [Fact]
        public void If_True()
        {
            var actual = If(DefaultMap)(true);
            Assert.Equal(DefaultExpected, actual);
        }

        [Fact]
        public void If_False()
        {
            var actual = If(DefaultMap)(false);
            Assert.Equal(default, actual);
        }

        [Fact]
        public void IfNot_True()
        {
            var actual = IfNot(DefaultMap)(true);
            Assert.Equal(default, actual);
        }

        [Fact]
        public void IfNot_False()
        {
            var actual = IfNot(DefaultMap)(false);
            Assert.Equal(DefaultExpected, actual);
        }

        #endregion
    }
}
