using System;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class NullableFunctionsTests
    {
        private const int DefaultExpected = 1;
        private static readonly Func<Enum1?, int> DefaultMap = _ => DefaultExpected;

        private enum Enum1
        {
            Value1,
            Value2
        }

        #region If

        [Fact]
        public void IfN_Value1WithValue1()
        {
            var actual = IfN<Enum1, int>(Enum1.Value1)(DefaultMap)(Enum1.Value1);
            Assert.Equal(DefaultExpected, actual);
        }

        [Fact]
        public void IfN_Value1WithValue2()
        {
            var actual = IfN<Enum1, int>(Enum1.Value1)(DefaultMap)(Enum1.Value2);
            Assert.Equal(default, actual);
        }

        [Fact]
        public void IfN_Value1WithNull()
        {
            var actual = IfN<Enum1, int>(Enum1.Value1)(DefaultMap)(null);
            Assert.Equal(default, actual);
        }

        [Fact]
        public void IfN_Null1WithValue1()
        {
            var actual = IfN<Enum1, int>(null)(DefaultMap)(Enum1.Value1);
            Assert.Equal(default, actual);
        }

        [Fact]
        public void IfN_NullWithNull()
        {
            var actual = IfN<Enum1, int>(null)(DefaultMap)(null);
            Assert.Equal(DefaultExpected, actual);
        }

        [Fact]
        public void IfNotN_Value1WithValue1()
        {
            var actual = IfNotN<Enum1, int>(Enum1.Value1)(DefaultMap)(Enum1.Value1);
            Assert.Equal(default, actual);
        }

        [Fact]
        public void IfNotN_Value1WithValue2()
        {
            var actual = IfNotN<Enum1, int>(Enum1.Value1)(DefaultMap)(Enum1.Value2);
            Assert.Equal(DefaultExpected, actual);
        }

        [Fact]
        public void IfNotN_Value1WithNull()
        {
            var actual = IfNotN<Enum1, int>(Enum1.Value1)(DefaultMap)(null);
            Assert.Equal(DefaultExpected, actual);
        }

        [Fact]
        public void IfNotN_Null1WithValue1()
        {
            var actual = IfNotN<Enum1, int>(null)(DefaultMap)(Enum1.Value1);
            Assert.Equal(DefaultExpected, actual);
        }

        [Fact]
        public void IfNotN_NullWithNull()
        {
            var actual = IfNotN<Enum1, int>(null)(DefaultMap)(null);
            Assert.Equal(default, actual);
        }

        #endregion
    }
}
