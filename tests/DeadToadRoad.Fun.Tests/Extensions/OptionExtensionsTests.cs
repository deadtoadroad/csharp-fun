using DeadToadRoad.Fun.Extensions;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests.Extensions
{
    public class OptionExtensionsTests
    {
        [Fact]
        public void Flatten_None()
        {
            var expected = None<string>();
            var actual = None<Option<string>>().Flatten();
            Assert.Same(expected, actual);
        }

        [Fact]
        public void Flatten_SomeNone()
        {
            var expected = None<string>();
            var actual = Some(None<string>()).Flatten();
            Assert.Same(expected, actual);
        }

        [Fact]
        public void Flatten_SomeSome()
        {
            var expected = Some("a").GetUnsafe();
            var actual = Some(Some("a")).Flatten().GetUnsafe();
            Assert.Equal(expected, actual);
        }
    }
}
