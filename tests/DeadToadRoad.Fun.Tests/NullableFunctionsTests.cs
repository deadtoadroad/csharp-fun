using System;
using DeadToadRoad.Fun.Extensions;
using Xunit;

namespace DeadToadRoad.Fun.Tests
{
    public class NullableFunctionsTests
    {
        private readonly Func<Enum1?, Func<Func<Enum1?, string>, Func<Enum1?, Option<string>>>> _if =
            Functions.If<Enum1, string>;

        private readonly Func<Enum1?, Func<Func<Enum1?, string>, Func<Enum1?, Option<string>>>> _ifNot =
            Functions.IfNot<Enum1, string>;

        private readonly Func<Enum1?, string> _map = _ => "random-string";

        private enum Enum1
        {
            Value1,
            Value2
        }

        #region If

        [Fact]
        public void If_NullWithNull()
        {
            var actual = _if(null)(_map)(null);
            Assert.True(actual.IsSome());
        }

        [Fact]
        public void If_NullWithValue1()
        {
            var actual = _if(null)(_map)(Enum1.Value1);
            Assert.True(actual.IsNone());
        }

        [Fact]
        public void If_Value1WithNull()
        {
            var actual = _if(Enum1.Value1)(_map)(null);
            Assert.True(actual.IsNone());
        }

        [Fact]
        public void If_Value1WithValue1()
        {
            var actual = _if(Enum1.Value1)(_map)(Enum1.Value1);
            Assert.True(actual.IsSome());
        }

        [Fact]
        public void If_Value1WithValue2()
        {
            var actual = _if(Enum1.Value1)(_map)(Enum1.Value2);
            Assert.True(actual.IsNone());
        }

        [Fact]
        public void IfNot_NullWithNull()
        {
            var actual = _ifNot(null)(_map)(null);
            Assert.True(actual.IsNone());
        }

        [Fact]
        public void IfNot_NullWithValue1()
        {
            var actual = _ifNot(null)(_map)(Enum1.Value1);
            Assert.True(actual.IsSome());
        }

        [Fact]
        public void IfNot_Value1WithNull()
        {
            var actual = _ifNot(Enum1.Value1)(_map)(null);
            Assert.True(actual.IsSome());
        }

        [Fact]
        public void IfNot_Value1WithValue1()
        {
            var actual = _ifNot(Enum1.Value1)(_map)(Enum1.Value1);
            Assert.True(actual.IsNone());
        }

        [Fact]
        public void IfNot_Value1WithValue2()
        {
            var actual = _ifNot(Enum1.Value1)(_map)(Enum1.Value2);
            Assert.True(actual.IsSome());
        }

        #endregion
    }
}
