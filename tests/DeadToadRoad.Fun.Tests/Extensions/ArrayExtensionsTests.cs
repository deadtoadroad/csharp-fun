using DeadToadRoad.Fun.Extensions;
using Xunit;

namespace DeadToadRoad.Fun.Tests.Extensions
{
    public class ArrayExtensionsTests
    {
        private readonly int[] _defaultTarget = {4, 5};

        [Fact]
        public void Append1_Works()
        {
            var expected = new[] {4, 5, 6};
            var actual = _defaultTarget.Append1(6);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Append2_Works()
        {
            var expected = new[] {4, 5, 6, 7};
            var actual = _defaultTarget.Append2(6)(7);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Append3_Works()
        {
            var expected = new[] {4, 5, 6, 7, 8};
            var actual = _defaultTarget.Append3(6)(7)(8);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Append4_Works()
        {
            var expected = new[] {4, 5, 6, 7, 8, 9};
            var actual = _defaultTarget.Append4(6)(7)(8)(9);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AppendN_Works()
        {
            var expected = new[] {4, 5, 6, 7, 8, 9};
            var actual = _defaultTarget.AppendN(new[] {6, 7, 8, 9});
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend1_Works()
        {
            var expected = new[] {3, 4, 5};
            var actual = _defaultTarget.Prepend1(3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend2_Works()
        {
            var expected = new[] {2, 3, 4, 5};
            var actual = _defaultTarget.Prepend2(2)(3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend2R_Works()
        {
            var expected = new[] {2, 3, 4, 5};
            var actual = _defaultTarget.Prepend2R(3)(2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend3_Works()
        {
            var expected = new[] {1, 2, 3, 4, 5};
            var actual = _defaultTarget.Prepend3(1)(2)(3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend3R_Works()
        {
            var expected = new[] {1, 2, 3, 4, 5};
            var actual = _defaultTarget.Prepend3R(3)(2)(1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend4_Works()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = _defaultTarget.Prepend4(0)(1)(2)(3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Prepend4R_Works()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = _defaultTarget.Prepend4R(3)(2)(1)(0);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrependN_Works()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = _defaultTarget.PrependN(new[] {0, 1, 2, 3});
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PrependNR_Works()
        {
            var expected = new[] {0, 1, 2, 3, 4, 5};
            var actual = _defaultTarget.PrependNR(new[] {3, 2, 1, 0});
            Assert.Equal(expected, actual);
        }
    }
}
