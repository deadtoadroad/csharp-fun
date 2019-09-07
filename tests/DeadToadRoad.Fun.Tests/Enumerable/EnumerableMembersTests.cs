using System;
using Xunit;
using static DeadToadRoad.Fun.EnumerableMembers;

namespace DeadToadRoad.Fun.Tests
{
    public class EnumerableMembersTests
    {
        private readonly int[] _defaultRange = {2};
        private readonly int[] _defaultAs = {1};
        private readonly int[] _empty = new int[0];

        #region PrependRange

        [Fact]
        public void PrependRange_1To1()
        {
            var actual = PrependRange(_defaultRange)(_defaultAs);
            Assert.Equal(new[] {2, 1}, actual);
        }

        [Fact]
        public void PrependRange_1ToEmpty()
        {
            var actual = PrependRange(_defaultRange)(_empty);
            Assert.Equal(_defaultRange, actual);
        }

        [Fact]
        public void PrependRange_1ToNull()
        {
            Assert.Throws<ArgumentNullException>(() => PrependRange(_defaultRange)(null));
        }

        [Fact]
        public void PrependRange_EmptyTo1()
        {
            var actual = PrependRange(_empty)(_defaultAs);
            Assert.Equal(_defaultAs, actual);
        }

        [Fact]
        public void PrependRange_EmptyToEmpty()
        {
            var actual = PrependRange(_empty)(_empty);
            Assert.Equal(_empty, actual);
        }

        [Fact]
        public void PrependRange_EmptyToNull()
        {
            Assert.Throws<ArgumentNullException>(() => PrependRange(_empty)(null));
        }

        [Fact]
        public void PrependRange_NullTo1()
        {
            Assert.Throws<ArgumentNullException>(() => PrependRange((int[]) null)(_defaultAs));
        }

        [Fact]
        public void PrependRange_NullToEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => PrependRange((int[]) null)(_empty));
        }

        [Fact]
        public void PrependRange_NullToNull()
        {
            Assert.Throws<ArgumentNullException>(() => PrependRange((int[]) null)(null));
        }

        #endregion
    }
}
