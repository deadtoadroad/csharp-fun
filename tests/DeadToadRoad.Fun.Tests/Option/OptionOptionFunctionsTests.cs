using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class OptionOptionFunctionsTests
    {
        #region Flatten

        [Fact]
        public void Flatten_SomeSome()
        {
            var actual = Flatten(Some(Some("a")));
            Assert.True(actual.IsSome);
            Assert.Same("a", actual.GetUnsafe());
        }

        [Fact]
        public void Flatten_SomeNone()
        {
            var actual = Flatten(Some(None<string>()));
            Assert.True(actual.IsNone);
            Assert.Same(default, actual.GetUnsafe());
        }

        [Fact]
        public void Flatten_None()
        {
            var actual = Flatten(None<Option<string>>());
            Assert.True(actual.IsNone);
            Assert.Same(default, actual.GetUnsafe());
        }

        #endregion
    }
}
