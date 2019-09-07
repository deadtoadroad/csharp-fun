using System;
using Xbehave;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class FunctionsTests
    {
        private const string E2 = "ab";
        private const string E3 = "abc";
        private const string E4 = "abcd";

        private static readonly Func<string, Func<string, string>> F2 =
            a => b => $"{a}{b}";

        private static readonly Func<string, Func<string, Func<string, string>>> F3 =
            a => b => c => $"{a}{b}{c}";

        private static readonly Func<string, Func<string, Func<string, Func<string, string>>>> F4 =
            a => b => c => d => $"{a}{b}{c}{d}";

        #region Apply

        [Fact]
        public void Apply3_3()
        {
            var actual = Apply3<string, string, string, string>("a")("b")("c")(F3);
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void Apply3_4()
        {
            var actual = Apply3<string, string, string, Func<string, string>>("a")("b")("c")(F4)("d");
            Assert.Equal(E4, actual);
        }

        #endregion

        #region Flip

        [Fact]
        public void Flip_2()
        {
            var actual = Flip(F2)("b")("a");
            Assert.Equal(E2, actual);
        }

        [Fact]
        public void Flip_3()
        {
            var actual = Flip(F3)("b")("a")("c");
            Assert.Equal(E3, actual);
        }

        #endregion

        #region Not

        [Scenario]
        public void Not_Bool(bool a, bool actual)
        {
            "Given false"
                .x(() => a = false);

            "When not is called"
                .x(() => actual = Not(a));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_FuncBool(Func<bool> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = () => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)());

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_Func1Bool(Func<object, bool> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = a => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)(default));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_Func2Bool(Func<object, Func<object, bool>> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = a => b => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)(default)(default));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_Func3Bool(Func<object, Func<object, Func<object, bool>>> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = a => b => c => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)(default)(default)(default));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_Func4Bool(Func<object, Func<object, Func<object, Func<object, bool>>>> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = a => b => c => d => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)(default)(default)(default)(default));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_Func5Bool(Func<object, Func<object, Func<object, Func<object, Func<object, bool>>>>> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = a => b => c => d => e => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)(default)(default)(default)(default)(default));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        #endregion

        #region Reverse

        [Fact]
        public void Reverse3_3()
        {
            var actual = Reverse3(F3)("c")("b")("a");
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void Reverse3_4()
        {
            var actual = Reverse3(F4)("c")("b")("a")("d");
            Assert.Equal(E4, actual);
        }

        #endregion

        #region RotateLeft

        [Fact]
        public void RotateLeft3_3()
        {
            var actual = RotateLeft3(F3)("b")("c")("a");
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void RotateLeft3_4()
        {
            var actual = RotateLeft3(F4)("b")("c")("a")("d");
            Assert.Equal(E4, actual);
        }

        #endregion

        #region RotateRight

        [Fact]
        public void RotateRight3_3()
        {
            var actual = RotateRight3(F3)("c")("a")("b");
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void RotateRight3_4()
        {
            var actual = RotateRight3(F4)("c")("a")("b")("d");
            Assert.Equal(E4, actual);
        }

        #endregion

        #region Uncurry

        [Fact]
        public void Uncurry3_3()
        {
            var actual = Uncurry3(F3)("a", "b", "c");
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void Uncurry3_4()
        {
            var actual = Uncurry3(F4)("a", "b", "c")("d");
            Assert.Equal(E4, actual);
        }

        #endregion
    }
}
