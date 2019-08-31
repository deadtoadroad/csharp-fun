using DeadToadRoad.Fun.Extensions;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests.Extensions
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void FlatMap_EmptyEnumerableOption()
        {
            var expected = new string[0];

            var actual = new Option<string>[0]
                .FlatMap(o => o.ToArray());

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FlatMap_EnumerableOptionWithNone()
        {
            var expected = new string[0];

            var actual = new[] {None<string>()}
                .FlatMap(o => o.ToArray());

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FlatMap_EnumerableOptionWithSome()
        {
            var expected = new[] {"a"};

            var actual = new[] {Some("a")}
                .FlatMap(o => o.ToArray());

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FlatMap_EnumerableOptionWithSomeAndNone()
        {
            var expected = new[] {"a", "b", "c"};

            var actual = new[] {None<string>(), Some("a"), Some("b"), None<string>(), Some("c"), None<string>()}
                .FlatMap(o => o.ToArray());

            Assert.Equal(expected, actual);
        }
    }
}
