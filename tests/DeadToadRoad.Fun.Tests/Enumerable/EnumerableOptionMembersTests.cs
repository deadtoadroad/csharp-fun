using Xunit;
using static DeadToadRoad.Fun.EnumerableMembers;
using static DeadToadRoad.Fun.OptionFunctions;

namespace DeadToadRoad.Fun.Tests
{
    public class EnumerableOptionMembersTests
    {
        #region Flatten

        [Fact]
        public void Flatten_Some()
        {
            var expected = new[] {"a"};
            var actual = Flatten(new[] {Some("a")});
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Flatten_None()
        {
            var expected = new string[0];
            var actual = Flatten(new[] {None<string>()});
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Flatten_Empty()
        {
            var expected = new string[0];
            var actual = Flatten(new Option<string>[0]);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Flatten_Mixed()
        {
            var expected = new[] {"a", "b", "c"};

            var actual = Flatten(new[] {
                None<string>(),
                Some("a"),
                Some("b"),
                None<string>(),
                Some("c"),
                None<string>()
            });

            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
