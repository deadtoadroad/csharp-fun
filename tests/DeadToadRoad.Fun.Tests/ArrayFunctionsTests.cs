using Xunit;
using static DeadToadRoad.Fun.ArrayFunctions;

namespace DeadToadRoad.Fun.Tests
{
    public class ArrayFunctionsTests
    {
        private readonly int[] _defaultTarget = {4, 5};

        [Fact]
        public void Append1_Works()
        {
            var expected = new[] {4, 5, 6};
            var actual = Append1(6)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Append2_Works()
        {
            var expected = new[] {4, 5, 6, 7};
            var actual = Append2(6)(7)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Append3_Works()
        {
            var expected = new[] {4, 5, 6, 7, 8};
            var actual = Append3(6)(7)(8)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Append4_Works()
        {
            var expected = new[] {4, 5, 6, 7, 8, 9};
            var actual = Append4(6)(7)(8)(9)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AppendN_Works()
        {
            var expected = new[] {4, 5, 6, 7, 8, 9};
            var actual = AppendN(new[] {6, 7, 8, 9})(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend1_Works()
        {
            var expected = new[] {3, 4, 5};
            var actual = Prepend1(3)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend2_Works()
        {
            var expected = new[] {2, 3, 4, 5};
            var actual = Prepend2(2)(3)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend2R_Works()
        {
            var expected = new[] {2, 3, 4, 5};
            var actual = Prepend2R(3)(2)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend3_Works()
        {
            var expected = new[] {1, 2, 3, 4, 5};
            var actual = Prepend3(1)(2)(3)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend3R_Works()
        {
            var expected = new[] {1, 2, 3, 4, 5};
            var actual = Prepend3R(3)(2)(1)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend4_Works()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = Prepend4(0)(1)(2)(3)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend4R_Works()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = Prepend4R(3)(2)(1)(0)(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrependN_Works()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = PrependN(new[] {0, 1, 2, 3})(_defaultTarget);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrependNR_Works()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = PrependNR(new[] {3, 2, 1, 0})(_defaultTarget);
            Assert.Equal(expected, actual);
        }
    }
}
