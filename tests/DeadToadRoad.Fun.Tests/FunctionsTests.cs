using System;
using DeadToadRoad.Fun.Extensions;
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
        private const string E5 = "abcde";

        private static readonly Func<string, Func<string, string>> F2 =
            a => b => $"{a}{b}";

        private static readonly Func<string, Func<string, Func<string, string>>> F3 =
            a => b => c => $"{a}{b}{c}";

        private static readonly Func<string, Func<string, Func<string, Func<string, string>>>> F4 =
            a => b => c => d => $"{a}{b}{c}{d}";

        private static readonly Func<string, Func<string, Func<string, Func<string, Func<string, string>>>>> F5 =
            a => b => c => d => e => $"{a}{b}{c}{d}{e}";

        private static readonly Func<Func<string, Func<string, Func<string, Func<string, Func<string, string>>>>>, string> A5 =
            Apply5<string, string, string, string, string, string>("a")("b")("c")("d")("e");

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

        [Fact]
        public void RotateLeft2_RotateLeft2WithFlip()
        {
            var actual = A5(RotateLeft2(F5));
            Assert.Equal(A5(RotateLeft2WithFlip(F5)), actual);
        }

        [Fact]
        public void RotateLeft3_RotateLeft3WithFlip()
        {
            var actual = A5(RotateLeft3(F5));
            Assert.Equal(A5(RotateLeft3WithFlip(F5)), actual);
        }

        [Fact]
        public void RotateLeft4_RotateLeft4WithFlip()
        {
            var actual = A5(RotateLeft4(F5));
            Assert.Equal(A5(RotateLeft4WithFlip(F5)), actual);
        }

        [Fact]
        public void RotateLeft5_RotateLeft5WithFlip()
        {
            var actual = A5(RotateLeft5(F5));
            Assert.Equal(A5(RotateLeft5WithFlip(F5)), actual);
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

        [Fact]
        public void RotateRight2_RotateRight2WithFlip()
        {
            var actual = A5(RotateRight2(F5));
            Assert.Equal(A5(RotateRight2WithFlip(F5)), actual);
        }

        [Fact]
        public void RotateRight3_RotateRight3WithFlip()
        {
            var actual = A5(RotateRight3(F5));
            Assert.Equal(A5(RotateRight3WithFlip(F5)), actual);
        }

        [Fact]
        public void RotateRight4_RotateRight4WithFlip()
        {
            var actual = A5(RotateRight4(F5));
            Assert.Equal(A5(RotateRight4WithFlip(F5)), actual);
        }

        [Fact]
        public void RotateRight5_RotateRight5WithFlip()
        {
            var actual = A5(RotateRight5(F5));
            Assert.Equal(A5(RotateRight5WithFlip(F5)), actual);
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

        #region Alternative Functions

        public static Func<TB, Func<TA, TC>> Flip1And2<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return Flip(f);
        }

        public static Func<TA, Func<TC, Func<TB, TD>>> Flip2And3<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return Compose(Flip1And2, f);
        }

        public static Func<TA, Func<TB, Func<TD, Func<TC, TE>>>> Flip3And4<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return Compose(Flip2And3, f);
        }

        public static Func<TA, Func<TB, Func<TC, Func<TE, Func<TD, TF>>>>> Flip4And5<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return Compose(Flip3And4, f);
        }

        public static Func<TB, Func<TA, TC>> RotateLeft2WithFlip<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return Flip1And2(f);
        }

        public static Func<TB, Func<TC, Func<TA, TD>>> RotateLeft3WithFlip<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return f.Compose(Flip2And3, RotateLeft2WithFlip);
        }

        public static Func<TB, Func<TC, Func<TD, Func<TA, TE>>>> RotateLeft4WithFlip<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return f.Compose(Flip3And4, RotateLeft3WithFlip);
        }

        public static Func<TB, Func<TC, Func<TD, Func<TE, Func<TA, TF>>>>> RotateLeft5WithFlip<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return f.Compose(Flip4And5, RotateLeft4WithFlip);
        }

        public static Func<TB, Func<TA, TC>> RotateRight2WithFlip<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return Flip1And2(f);
        }

        public static Func<TC, Func<TA, Func<TB, TD>>> RotateRight3WithFlip<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return f.Compose(RotateRight2WithFlip, Flip2And3);
        }

        public static Func<TD, Func<TA, Func<TB, Func<TC, TE>>>> RotateRight4WithFlip<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return f.Compose(RotateRight3WithFlip, Flip3And4);
        }

        public static Func<TE, Func<TA, Func<TB, Func<TC, Func<TD, TF>>>>> RotateRight5WithFlip<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return f.Compose(RotateRight4WithFlip, Flip4And5);
        }

        #endregion
    }
}
