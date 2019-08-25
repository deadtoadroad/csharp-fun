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
            var actual = Append1(6)(_defaultTarget);
            Assert.Equal(new[] {4, 5, 6}, actual);
        }

        [Fact]
        public void Append2_Works()
        {
            var actual = Append2(6)(7)(_defaultTarget);
            Assert.Equal(new[] {4, 5, 6, 7}, actual);
        }

        [Fact]
        public void Append3_Works()
        {
            var actual = Append3(6)(7)(8)(_defaultTarget);
            Assert.Equal(new[] {4, 5, 6, 7, 8}, actual);
        }

        [Fact]
        public void Append4_Works()
        {
            var actual = Append4(6)(7)(8)(9)(_defaultTarget);
            Assert.Equal(new[] {4, 5, 6, 7, 8, 9}, actual);
        }

        [Fact]
        public void AppendN_Works()
        {
            var actual = AppendN(new[] {6, 7, 8, 9})(_defaultTarget);
            Assert.Equal(new[] {4, 5, 6, 7, 8, 9}, actual);
        }

        [Fact]
        public void Prepend1_Works()
        {
            var actual = Prepend1(3)(_defaultTarget);
            Assert.Equal(new[] {3, 4, 5}, actual);
        }

        [Fact]
        public void Prepend2_Works()
        {
            var actual = Prepend2(3)(2)(_defaultTarget);
            Assert.Equal(new[] {2, 3, 4, 5}, actual);
        }

        [Fact]
        public void Prepend2R_Works()
        {
            var actual = Prepend2R(2)(3)(_defaultTarget);
            Assert.Equal(new[] {2, 3, 4, 5}, actual);
        }

        [Fact]
        public void Prepend3_Works()
        {
            var actual = Prepend3(3)(2)(1)(_defaultTarget);
            Assert.Equal(new[] {1, 2, 3, 4, 5}, actual);
        }

        [Fact]
        public void Prepend3R_Works()
        {
            var actual = Prepend3R(1)(2)(3)(_defaultTarget);
            Assert.Equal(new[] {1, 2, 3, 4, 5}, actual);
        }

        [Fact]
        public void Prepend4_Works()
        {
            var actual = Prepend4(3)(2)(1)(0)(_defaultTarget);
            Assert.Equal(new[] {0, 1, 2, 3, 4, 5}, actual);
        }

        [Fact]
        public void Prepend4R_Works()
        {
            var actual = Prepend4R(0)(1)(2)(3)(_defaultTarget);
            Assert.Equal(new[] {0, 1, 2, 3, 4, 5}, actual);
        }

        [Fact]
        public void PrependN_Works()
        {
            var actual = PrependN(new[] {0, 1, 2, 3})(_defaultTarget);
            Assert.Equal(new[] {0, 1, 2, 3, 4, 5}, actual);
        }

        [Fact]
        public void PrependNR_Works()
        {
            var actual = PrependNR(new[] {3, 2, 1, 0})(_defaultTarget);
            Assert.Equal(new[] {0, 1, 2, 3, 4, 5}, actual);
        }
    }
}
