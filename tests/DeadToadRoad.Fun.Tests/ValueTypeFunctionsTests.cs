using System;
using DeadToadRoad.Fun.Extensions;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class ValueTypeFunctionsTests
    {
        private static readonly Func<Enum1, Func<Func<Enum1, int>, Func<Enum1, Option<int>>>> If =
            If<Enum1, int>;

        private static readonly Func<Enum1, Func<Func<Enum1, int>, Func<Enum1, Option<int>>>> IfNot =
            IfNot<Enum1, int>;

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
            var actual = If(Enum1.Value1)(DefaultMap)(Enum1.Value1);
            Assert.True(actual.IsSome());
            Assert.Equal(DefaultExpected, actual.GetUnsafe());
        }

        [Fact]
        public void If_Value1WithValue2()
        {
            var actual = If(Enum1.Value1)(DefaultMap)(Enum1.Value2);
            Assert.True(actual.IsNone());
            Assert.Equal(default, actual.GetUnsafe());
        }

        [Fact]
        public void IfNot_Value1WithValue1()
        {
            var actual = IfNot(Enum1.Value1)(DefaultMap)(Enum1.Value1);
            Assert.True(actual.IsNone());
            Assert.Equal(default, actual.GetUnsafe());
        }

        [Fact]
        public void IfNot_Value1WithValue2()
        {
            var actual = IfNot(Enum1.Value1)(DefaultMap)(Enum1.Value2);
            Assert.True(actual.IsSome());
            Assert.Equal(DefaultExpected, actual.GetUnsafe());
        }

        #endregion
    }
}
