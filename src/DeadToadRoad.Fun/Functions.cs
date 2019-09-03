using System;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region AsFunc

        public static Func<TA, TA> AsFunc<TA>(Action<TA> f)
        {
            return a => {
                f(a);
                return a;
            };
        }

        #endregion

        #region Compose

        public static Func<Func<TA, TB>, Func<TA, TC>> Compose2<TA, TB, TC>(Func<TB, TC> fbc)
        {
            return fab => a => fbc(fab(a));
        }

        public static Func<Func<TB, TC>, Func<Func<TA, TB>, Func<TA, TD>>> Compose3<TA, TB, TC, TD>(Func<TC, TD> fcd)
        {
            return fbc => fab => a => fcd(fbc(fab(a)));
        }

        public static Func<Func<TC, TD>, Func<Func<TB, TC>, Func<Func<TA, TB>, Func<TA, TE>>>> Compose4<TA, TB, TC, TD, TE>(Func<TD, TE> fde)
        {
            return fcd => fbc => fab => a => fde(fcd(fbc(fab(a))));
        }

        public static Func<Func<TD, TE>, Func<Func<TC, TD>, Func<Func<TB, TC>, Func<Func<TA, TB>, Func<TA, TF>>>>> Compose5<TA, TB, TC, TD, TE, TF>(Func<TE, TF> fef)
        {
            return fde => fcd => fbc => fab => a => fef(fde(fcd(fbc(fab(a)))));
        }

        #endregion

        #region Curry

        public static Func<TA, Func<TB, TC>> Curry<TA, TB, TC>(Func<TA, TB, TC> f)
        {
            return a => b => f(a, b);
        }

        public static Func<TA, Func<TB, Func<TC, TD>>> Curry<TA, TB, TC, TD>(Func<TA, TB, TC, TD> f)
        {
            return a => b => c => f(a, b, c);
        }

        public static Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> Curry<TA, TB, TC, TD, TE>(Func<TA, TB, TC, TD, TE> f)
        {
            return a => b => c => d => f(a, b, c, d);
        }

        public static Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> Curry<TA, TB, TC, TD, TE, TF>(Func<TA, TB, TC, TD, TE, TF> f)
        {
            return a => b => c => d => e => f(a, b, c, d, e);
        }

        #endregion

        #region Rotate

        public static Func<TB, Func<TA, TC>> Rotate<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return b => a => f(a)(b);
        }

        public static Func<TC, Func<TA, Func<TB, TD>>> Rotate<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return c => a => b => f(a)(b)(c);
        }

        public static Func<TD, Func<TA, Func<TB, Func<TC, TE>>>> Rotate<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return d => a => b => c => f(a)(b)(c)(d);
        }

        public static Func<TE, Func<TA, Func<TB, Func<TC, Func<TD, TF>>>>> Rotate<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return e => a => b => c => d => f(a)(b)(c)(d)(e);
        }

        #endregion

        #region Flow

        public static Func<Func<TB, TC>, Func<TA, TC>> Flow2<TA, TB, TC>(Func<TA, TB> fab)
        {
            return fbc => a => fbc(fab(a));
        }

        public static Func<Func<TB, TC>, Func<Func<TC, TD>, Func<TA, TD>>> Flow3<TA, TB, TC, TD>(Func<TA, TB> fab)
        {
            return fbc => fcd => a => fcd(fbc(fab(a)));
        }

        public static Func<Func<TB, TC>, Func<Func<TC, TD>, Func<Func<TD, TE>, Func<TA, TE>>>> Flow4<TA, TB, TC, TD, TE>(Func<TA, TB> fab)
        {
            return fbc => fcd => fde => a => fde(fcd(fbc(fab(a))));
        }

        public static Func<Func<TB, TC>, Func<Func<TC, TD>, Func<Func<TD, TE>, Func<Func<TE, TF>, Func<TA, TF>>>>> Flow5<TA, TB, TC, TD, TE, TF>(Func<TA, TB> fab)
        {
            return fbc => fcd => fde => fef => a => fef(fde(fcd(fbc(fab(a)))));
        }

        #endregion

        #region NoOp

        public static void NoOp()
        {
        }

        public static void NoOp<TA>(TA _)
        {
        }

        #endregion

        #region Not

        public static bool Not(bool a)
        {
            return !a;
        }

        public static Func<bool> Not(Func<bool> f)
        {
            return () => Not(f());
        }

        public static Func<TA, bool> Not<TA>(Func<TA, bool> f)
        {
            return a => Not(f(a));
        }

        public static Func<TA, Func<TB, bool>> Not<TA, TB>(Func<TA, Func<TB, bool>> f)
        {
            return a => Not(f(a));
        }

        public static Func<TA, Func<TB, Func<TC, bool>>> Not<TA, TB, TC>(Func<TA, Func<TB, Func<TC, bool>>> f)
        {
            return a => Not(f(a));
        }

        public static Func<TA, Func<TB, Func<TC, Func<TD, bool>>>> Not<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, Func<TD, bool>>>> f)
        {
            return a => Not(f(a));
        }

        public static Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, bool>>>>> Not<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, bool>>>>> f)
        {
            return a => Not(f(a));
        }

        #endregion

        #region Reverse

        public static Func<TB, Func<TA, TC>> Reverse<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return Rotate(f);
        }

        public static Func<TC, Func<TB, Func<TA, TD>>> Reverse<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return c => b => a => f(a)(b)(c);
        }

        public static Func<TD, Func<TC, Func<TB, Func<TA, TE>>>> Reverse<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return d => c => b => a => f(a)(b)(c)(d);
        }

        public static Func<TE, Func<TD, Func<TC, Func<TB, Func<TA, TF>>>>> Reverse<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return e => d => c => b => a => f(a)(b)(c)(d)(e);
        }

        #endregion

        #region Uncurry

        public static Func<TA, TB, TC> Uncurry<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return (a, b) => f(a)(b);
        }

        public static Func<TA, TB, TC, TD> Uncurry<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return (a, b, c) => f(a)(b)(c);
        }

        public static Func<TA, TB, TC, TD, TE> Uncurry<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return (a, b, c, d) => f(a)(b)(c)(d);
        }

        public static Func<TA, TB, TC, TD, TE, TF> Uncurry<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return (a, b, c, d, e) => f(a)(b)(c)(d)(e);
        }

        #endregion
    }
}
