using DeadToadRoad.Fun.Extensions;
using Xunit;

namespace DeadToadRoad.Fun.Tests.Extensions
{
    public class ArrayExtensionsTests
    {
        private readonly int[] _defaultTarget = {4, 5};

        [Fact]
        public void Append_For1Works()
        {
            var expected = new[] {4, 5, 6};
            var actual = _defaultTarget.Append(6);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Append_ForNWorks()
        {
            var expected = new[] {4, 5, 6, 7, 8, 9};
            var actual = _defaultTarget.Append(6, 7, 8, 9);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend_For1Works()
        {
            var expected = new[] {3, 4, 5};
            var actual = _defaultTarget.Prepend(3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend_ForNWorks()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = _defaultTarget.Prepend(0, 1, 2, 3);
            Assert.Equal(expected, actual);
        }
    }
}
