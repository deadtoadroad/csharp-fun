using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class ArrayFunctionsTests
    {
        private static readonly int[] DefaultTarget = {4, 5};

        #region Append

        [Fact]
        public void Append_1()
        {
            var expected = new[] {4, 5, 6};
            var actual = Append(6)(DefaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Append_N()
        {
            var expected = new[] {4, 5, 6, 7, 8, 9};
            var actual = Append(new[] {6, 7, 8, 9})(DefaultTarget);
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Prepend

        [Fact]
        public void Prepend_1()
        {
            var expected = new[] {3, 4, 5};
            var actual = Prepend(3)(DefaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend_N()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = Prepend(new[] {0, 1, 2, 3})(DefaultTarget);
            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
