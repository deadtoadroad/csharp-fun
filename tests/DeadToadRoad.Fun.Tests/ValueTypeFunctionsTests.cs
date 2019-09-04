using System;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class ValueTypeFunctionsTests
    {
        private const int DefaultExpected = 1;
        private static readonly Func<Enum1, int> DefaultMap = _ => DefaultExpected;

        private enum Enum1
        {
            Value1,
            Value2
        }

        #region If

        [Fact]
        public void If_Value1WithValue1()
        {
            var actual = If<Enum1, int>(Enum1.Value1)(DefaultMap)(Enum1.Value1);
            Assert.Equal(DefaultExpected, actual);
        }

        [Fact]
        public void If_Value1WithValue2()
        {
            var actual = If<Enum1, int>(Enum1.Value1)(DefaultMap)(Enum1.Value2);
            Assert.Equal(default, actual);
        }

        [Fact]
        public void IfNot_Value1WithValue1()
        {
            var actual = IfNot<Enum1, int>(Enum1.Value1)(DefaultMap)(Enum1.Value1);
            Assert.Equal(default, actual);
        }

        [Fact]
        public void IfNot_Value1WithValue2()
        {
            var actual = IfNot<Enum1, int>(Enum1.Value1)(DefaultMap)(Enum1.Value2);
            Assert.Equal(DefaultExpected, actual);
        }

        #endregion
    }
}
