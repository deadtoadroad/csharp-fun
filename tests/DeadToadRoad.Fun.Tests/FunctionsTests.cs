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
        private const string E5 = "abcde";

        private static readonly Func<string, Action<string>> AssertEqual =
            Curry<string, string>(Assert.Equal);

        private static readonly Func<string, Func<string, string>> F2 =
            a => b => $"{a}{b}";

        private static readonly Func<string, Func<string, Func<string, string>>> F3 =
            a => b => c => $"{a}{b}{c}";

        private static readonly Func<string, Func<string, Func<string, Func<string, string>>>> F4 =
            a => b => c => d => $"{a}{b}{c}{d}";

        private static readonly Func<string, Func<string, Func<string, Func<string, Func<string, string>>>>> F5 =
            a => b => c => d => e => $"{a}{b}{c}{d}{e}";

        private static readonly Func<string, Func<string, Func<Func<string, Func<string, string>>, string>>> A2 =
            Apply2<string, string, string>;

        private static readonly Func<string, Func<string, Func<string, Func<Func<string, Func<string, Func<string, string>>>, string>>>> A3 =
            Apply3<string, string, string, string>;

        private static readonly Func<string, Func<string, Func<string, Func<string, Func<Func<string, Func<string, Func<string, Func<string, string>>>>, string>>>>> A4 =
            Apply4<string, string, string, string, string>;

        private static readonly Func<string, Func<string, Func<string, Func<string, Func<string, Func<Func<string, Func<string, Func<string, Func<string, Func<string, string>>>>>, string>>>>>> A5 =
            Apply5<string, string, string, string, string, string>;

        #region Apply

        [Fact]
        public void Apply2_2()
        {
            Assert.All(new[] {
                Apply2<string, string, string>("a")("b")(F2),
                Apply2<string, string, string>("a", "b")(F2),
                Apply2WithFlip<string, string, string>("a")("b")(F2)
            }, AssertEqual(E2));
            ;
        }

        [Fact]
        public void Apply2_3()
        {
            var actual = Apply2<string, string, Func<string, string>>("a")("b")(F3)("c");
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void Apply3_3()
        {
            Assert.All(new[] {
                Apply3<string, string, string, string>("a")("b")("c")(F3),
                Apply3<string, string, string, string>("a", "b")("c")(F3),
                Apply3<string, string, string, string>("a", "b", "c")(F3),
                Apply3WithFlip<string, string, string, string>("a")("b")("c")(F3)
            }, AssertEqual(E3));
        }

        [Fact]
        public void Apply4_4()
        {
            Assert.All(new[] {
                Apply4<string, string, string, string, string>("a")("b")("c")("d")(F4),
                Apply4<string, string, string, string, string>("a", "b")("c")("d")(F4),
                Apply4<string, string, string, string, string>("a", "b", "c")("d")(F4),
                Apply4<string, string, string, string, string>("a", "b", "c", "d")(F4),
                Apply4WithFlip<string, string, string, string, string>("a")("b")("c")("d")(F4)
            }, AssertEqual(E4));
        }

        [Fact]
        public void Apply5_5()
        {
            Assert.All(new[] {
                Apply5<string, string, string, string, string, string>("a")("b")("c")("d")("e")(F5),
                Apply5<string, string, string, string, string, string>("a", "b")("c")("d")("e")(F5),
                Apply5<string, string, string, string, string, string>("a", "b", "c")("d")("e")(F5),
                Apply5<string, string, string, string, string, string>("a", "b", "c", "d")("e")(F5),
                Apply5<string, string, string, string, string, string>("a", "b", "c", "d", "e")(F5),
                Apply5WithFlip<string, string, string, string, string, string>("a")("b")("c")("d")("e")(F5)
            }, AssertEqual(E5));
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
        public void Reverse2_2()
        {
            var a2 = A2("b")("a");
            Assert.All(new[] {
                a2(Reverse2(F2)),
                a2(Reverse2WithFlip(F2))
            }, AssertEqual(E2));
        }

        [Fact]
        public void Reverse2_3()
        {
            var actual = Reverse2(F3)("b")("a")("c");
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void Reverse3_3()
        {
            var a3 = A3("c")("b")("a");
            Assert.All(new[] {
                a3(Reverse3(F3)),
                a3(Reverse3WithFlip(F3))
            }, AssertEqual(E3));
        }

        [Fact]
        public void Reverse4_4()
        {
            var a4 = A4("d")("c")("b")("a");
            Assert.All(new[] {
                a4(Reverse4(F4)),
                a4(Reverse4WithFlip(F4))
            }, AssertEqual(E4));
        }

        [Fact]
        public void Reverse5_5()
        {
            var a5 = A5("e")("d")("c")("b")("a");
            Assert.All(new[] {
                a5(Reverse5(F5)),
                a5(Reverse5WithFlip(F5))
            }, AssertEqual(E5));
        }

        #endregion

        #region RotateLeft

        [Fact]
        public void RotateLeft2_2()
        {
            var a2 = A2("b")("a");
            Assert.All(new[] {
                a2(RotateLeft2(F2)),
                a2(RotateLeft2WithFlip(F2))
            }, AssertEqual(E2));
        }

        [Fact]
        public void RotateLeft2_3()
        {
            var actual = RotateLeft2(F3)("b")("a")("c");
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void RotateLeft3_3()
        {
            var a3 = A3("b")("c")("a");
            Assert.All(new[] {
                a3(RotateLeft3(F3)),
                a3(RotateLeft3WithFlip(F3))
            }, AssertEqual(E3));
        }

        [Fact]
        public void RotateLeft4_4()
        {
            var a4 = A4("b")("c")("d")("a");
            Assert.All(new[] {
                a4(RotateLeft4(F4)),
                a4(RotateLeft4WithFlip(F4))
            }, AssertEqual(E4));
        }

        [Fact]
        public void RotateLeft5_5()
        {
            var a5 = A5("b")("c")("d")("e")("a");
            Assert.All(new[] {
                a5(RotateLeft5(F5)),
                a5(RotateLeft5WithFlip(F5))
            }, AssertEqual(E5));
        }

        #endregion

        #region RotateRight

        [Fact]
        public void RotateRight2_2()
        {
            var a2 = A2("b")("a");
            Assert.All(new[] {
                a2(RotateRight2(F2)),
                a2(RotateRight2WithFlip(F2))
            }, AssertEqual(E2));
        }

        [Fact]
        public void RotateRight2_3()
        {
            var actual = RotateRight2(F3)("b")("a")("c");
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void RotateRight3_3()
        {
            var a3 = A3("c")("a")("b");
            Assert.All(new[] {
                a3(RotateRight3(F3)),
                a3(RotateRight3WithFlip(F3))
            }, AssertEqual(E3));
        }

        [Fact]
        public void RotateRight4_4()
        {
            var a4 = A4("d")("a")("b")("c");
            Assert.All(new[] {
                a4(RotateRight4(F4)),
                a4(RotateRight4WithFlip(F4))
            }, AssertEqual(E4));
        }

        [Fact]
        public void RotateRight5_5()
        {
            var a5 = A5("e")("a")("b")("c")("d");
            Assert.All(new[] {
                a5(RotateRight5(F5)),
                a5(RotateRight5WithFlip(F5))
            }, AssertEqual(E5));
        }

        #endregion

        #region Uncurry

        [Fact]
        public void Uncurry2_2()
        {
            var actual = Uncurry2(F2)("a", "b");
            Assert.Equal(E2, actual);
        }

        [Fact]
        public void Uncurry2_3()
        {
            var actual = Uncurry2(F3)("a", "b")("c");
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void Uncurry3_3()
        {
            var actual = Uncurry3(F3)("a", "b", "c");
            Assert.Equal(E3, actual);
        }

        [Fact]
        public void Uncurry4_4()
        {
            var actual = Uncurry4(F4)("a", "b", "c", "d");
            Assert.Equal(E4, actual);
        }

        [Fact]
        public void Uncurry5_5()
        {
            var actual = Uncurry5(F5)("a", "b", "c", "d", "e");
            Assert.Equal(E5, actual);
        }

        #endregion

        #region Alternative Functions

        #region Apply

        public static Func<TB, Func<Func<TA, Func<TB, TC>>, TC>> Apply2WithFlip<TA, TB, TC>(TA a)
        {
            return RotateLeft2WithFlip(Apply<TA, Func<TB, TC>>(a));
        }

        public static Func<TB, Func<TC, Func<Func<TA, Func<TB, Func<TC, TD>>>, TD>>> Apply3WithFlip<TA, TB, TC, TD>(TA a)
        {
            return RotateLeft3WithFlip(Apply<TA, Func<TB, Func<TC, TD>>>(a));
        }

        public static Func<TB, Func<TC, Func<TD, Func<Func<TA, Func<TB, Func<TC, Func<TD, TE>>>>, TE>>>> Apply4WithFlip<TA, TB, TC, TD, TE>(TA a)
        {
            return RotateLeft4WithFlip(Apply<TA, Func<TB, Func<TC, Func<TD, TE>>>>(a));
        }

        public static Func<TB, Func<TC, Func<TD, Func<TE, Func<Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>>, TF>>>>> Apply5WithFlip<TA, TB, TC, TD, TE, TF>(TA a)
        {
            return RotateLeft5WithFlip(Apply<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>>(a));
        }

        #endregion

        #region Flip

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

        #endregion

        #region Reverse

        public static Func<TB, Func<TA, TC>> Reverse2WithFlip<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return Flip1And2(f);
        }

        public static Func<TC, Func<TB, Func<TA, TD>>> Reverse3WithFlip<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return Compose(Reverse2WithFlip, RotateRight3WithFlip(f));
        }

        public static Func<TD, Func<TC, Func<TB, Func<TA, TE>>>> Reverse4WithFlip<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return Compose(Reverse3WithFlip, RotateRight4WithFlip(f));
        }

        public static Func<TE, Func<TD, Func<TC, Func<TB, Func<TA, TF>>>>> Reverse5WithFlip<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return Compose(Reverse4WithFlip, RotateRight5WithFlip(f));
        }

        #endregion

        #region RotateLeft

        public static Func<TB, Func<TA, TC>> RotateLeft2WithFlip<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return Flip1And2(f);
        }

        public static Func<TB, Func<TC, Func<TA, TD>>> RotateLeft3WithFlip<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return Flip2And3(RotateLeft2WithFlip(f));
        }

        public static Func<TB, Func<TC, Func<TD, Func<TA, TE>>>> RotateLeft4WithFlip<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return Flip3And4(RotateLeft3WithFlip(f));
        }

        public static Func<TB, Func<TC, Func<TD, Func<TE, Func<TA, TF>>>>> RotateLeft5WithFlip<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return Flip4And5(RotateLeft4WithFlip(f));
        }

        #endregion

        #region RotateRight

        public static Func<TB, Func<TA, TC>> RotateRight2WithFlip<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return Flip1And2(f);
        }

        public static Func<TC, Func<TA, Func<TB, TD>>> RotateRight3WithFlip<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return RotateRight2WithFlip(Flip2And3(f));
        }

        public static Func<TD, Func<TA, Func<TB, Func<TC, TE>>>> RotateRight4WithFlip<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return RotateRight3WithFlip(Flip3And4(f));
        }

        public static Func<TE, Func<TA, Func<TB, Func<TC, Func<TD, TF>>>>> RotateRight5WithFlip<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return RotateRight4WithFlip(Flip4And5(f));
        }

        #endregion

        #endregion
    }
}
