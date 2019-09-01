using DeadToadRoad.Fun.Extensions;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class OptionFunctionsTests
    {
        #region Flatten

        [Fact]
        public void Flatten_EnumerableOption_Empty()
        {
            var expected = new string[0];
            var actual = new Option<string>[0].Flatten();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Flatten_EnumerableOption_None()
        {
            var expected = new string[0];
            var actual = new[] {None<string>()}.Flatten();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Flatten_EnumerableOption_Some()
        {
            var expected = new[] {"a"};
            var actual = new[] {Some("a")}.Flatten();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Flatten_EnumerableOption_SomeAndNone()
        {
            var expected = new[] {"a", "b", "c"};

            var actual = new[] {
                    None<string>(),
                    Some("a"),
                    Some("b"),
                    None<string>(),
                    Some("c"),
                    None<string>()
                }
                .Flatten();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Flatten_OptionOption_None()
        {
            var expected = None<string>();
            var actual = None<Option<string>>().Flatten();
            Assert.Same(expected, actual);
        }

        [Fact]
        public void Flatten_OptionOption_SomeNone()
        {
            var expected = None<string>();
            var actual = Some(None<string>()).Flatten();
            Assert.Same(expected, actual);
        }

        [Fact]
        public void Flatten_OptionOption_SomeSome()
        {
            var expected = Some("a").GetUnsafe();
            var actual = Some(Some("a")).Flatten().GetUnsafe();
            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
