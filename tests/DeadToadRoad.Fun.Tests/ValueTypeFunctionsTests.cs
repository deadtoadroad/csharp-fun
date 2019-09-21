using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class ValueTypeFunctionsTests
    {
        #region If

        [Fact]
        public void If_1With1()
        {
            var actual = If(1)(1);
            Assert.True(actual.IsSome);
        }

        [Fact]
        public void If_1With0()
        {
            var actual = If(1)(0);
            Assert.True(actual.IsNone);
        }

        [Fact]
        public void IfNot_1With1()
        {
            var actual = IfNot(1)(1);
            Assert.True(actual.IsNone);
        }

        [Fact]
        public void IfNot_1With0()
        {
            var actual = IfNot(1)(0);
            Assert.True(actual.IsSome);
        }

        #endregion
    }
}
