using DeadToadRoad.Fun.Extensions;
using Xunit;

namespace DeadToadRoad.Fun.Tests.Extensions
{
    public class ArrayExtensionsTests
    {
        private static readonly int[] DefaultTarget = {4, 5};

        #region Append

        [Fact]
        public void Append_1()
        {
            var expected = new[] {4, 5, 6};
            var actual = DefaultTarget.Append(6);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Append_N()
        {
            var expected = new[] {4, 5, 6, 7, 8, 9};
            var actual = DefaultTarget.Append(6, 7, 8, 9);
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Prepend

        [Fact]
        public void Prepend_1()
        {
            var expected = new[] {3, 4, 5};
            var actual = DefaultTarget.Prepend(3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend_N()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = DefaultTarget.Prepend(0, 1, 2, 3);
            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
