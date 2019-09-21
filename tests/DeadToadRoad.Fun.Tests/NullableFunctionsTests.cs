using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class NullableFunctionsTests
    {
        #region If

        [Fact]
        public void IfN_1With1()
        {
            var actual = IfN(1)(1);
            Assert.True(actual.IsSome);
        }

        [Fact]
        public void IfN_1With0()
        {
            var actual = IfN(1)(0);
            Assert.True(actual.IsNone);
        }

        [Fact]
        public void IfN_1WithNull()
        {
            var actual = IfN(1)(null);
            Assert.True(actual.IsNone);
        }

        [Fact]
        public void IfNotN_1With1()
        {
            var actual = IfNotN(1)(1);
            Assert.True(actual.IsNone);
        }

        [Fact]
        public void IfNotN_1With0()
        {
            var actual = IfNotN(1)(0);
            Assert.True(actual.IsSome);
        }

        [Fact]
        public void IfNotN_1WithNull()
        {
            var actual = IfNotN(1)(null);
            Assert.True(actual.IsNone);
        }

        #endregion
    }
}
