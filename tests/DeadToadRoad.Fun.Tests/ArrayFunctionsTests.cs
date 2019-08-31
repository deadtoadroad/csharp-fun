using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class ArrayFunctionsTests
    {
        private readonly int[] _defaultTarget = {4, 5};

        [Fact]
        public void Append_For1Works()
        {
            var expected = new[] {4, 5, 6};
            var actual = Append(6)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Append_ForNWorks()
        {
            var expected = new[] {4, 5, 6, 7, 8, 9};
            var actual = Append(new[] {6, 7, 8, 9})(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend_For1Works()
        {
            var expected = new[] {3, 4, 5};
            var actual = Prepend(3)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend_ForNWorks()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = Prepend(new[] {0, 1, 2, 3})(_defaultTarget);
            Assert.Equal(expected, actual);
        }
    }
}
