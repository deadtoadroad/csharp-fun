using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class EnumerableFunctionsTests
    {
        private readonly int[] _defaultRange = {2};
        private readonly int[] _defaultAs = {1};
        private readonly int[] _empty = new int[0];

        #region AppendRange

        [Fact]
        public void AppendRange_1To1()
        {
            var actual = AppendRange(_defaultRange)(_defaultAs);
            Assert.Equal(new[] {1, 2}, actual);
        }

        [Fact]
        public void AppendRange_EmptyTo1()
        {
            var actual = AppendRange(_empty)(_defaultAs);
            Assert.Equal(_defaultAs, actual);
        }

        [Fact]
        public void AppendRange_NullTo1()
        {
            var actual = AppendRange((int[]) null)(_defaultAs);
            Assert.Equal(_defaultAs, actual);
        }

        [Fact]
        public void AppendRange_1ToEmpty()
        {
            var actual = AppendRange(_defaultRange)(_empty);
            Assert.Equal(_defaultRange, actual);
        }

        [Fact]
        public void AppendRange_EmptyToEmpty()
        {
            var actual = AppendRange(_empty)(_empty);
            Assert.Equal(_empty, actual);
        }

        [Fact]
        public void AppendRange_NullToEmpty()
        {
            var actual = AppendRange((int[]) null)(_empty);
            Assert.Equal(_empty, actual);
        }

        [Fact]
        public void AppendRange_1ToNull()
        {
            var actual = AppendRange(_defaultRange)(null);
            Assert.Equal(_defaultRange, actual);
        }

        [Fact]
        public void AppendRange_EmptyToNull()
        {
            var actual = AppendRange(_empty)(null);
            Assert.Equal(_empty, actual);
        }

        [Fact]
        public void AppendRange_NullToNull()
        {
            var actual = AppendRange((int[]) null)(null);
            Assert.Equal(_empty, actual);
        }

        [Fact]
        public void PrependRange_1To1()
        {
            var actual = PrependRange(_defaultRange)(_defaultAs);
            Assert.Equal(new[] {2, 1}, actual);
        }

        [Fact]
        public void PrependRange_EmptyTo1()
        {
            var actual = PrependRange(_empty)(_defaultAs);
            Assert.Equal(_defaultAs, actual);
        }

        [Fact]
        public void PrependRange_NullTo1()
        {
            var actual = PrependRange((int[]) null)(_defaultAs);
            Assert.Equal(_defaultAs, actual);
        }

        [Fact]
        public void PrependRange_1ToEmpty()
        {
            var actual = PrependRange(_defaultRange)(_empty);
            Assert.Equal(_defaultRange, actual);
        }

        [Fact]
        public void PrependRange_EmptyToEmpty()
        {
            var actual = PrependRange(_empty)(_empty);
            Assert.Equal(_empty, actual);
        }

        [Fact]
        public void PrependRange_NullToEmpty()
        {
            var actual = PrependRange((int[]) null)(_empty);
            Assert.Equal(_empty, actual);
        }

        [Fact]
        public void PrependRange_1ToNull()
        {
            var actual = PrependRange(_defaultRange)(null);
            Assert.Equal(_defaultRange, actual);
        }

        [Fact]
        public void PrependRange_EmptyToNull()
        {
            var actual = PrependRange(_empty)(null);
            Assert.Equal(_empty, actual);
        }

        [Fact]
        public void PrependRange_NullToNull()
        {
            var actual = PrependRange((int[]) null)(null);
            Assert.Equal(_empty, actual);
        }

        #endregion
    }
}
