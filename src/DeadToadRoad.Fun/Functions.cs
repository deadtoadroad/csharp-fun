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

        #region Flip

        public static Func<TB, Func<TA, TC>> Flip<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return b => a => f(a)(b);
        }

        #endregion

        #region Apply

        public static Func<Func<TA, TB>, TB> Apply<TA, TB>(TA a)
        {
            return f => f(a);
        }

        public static Func<TB, Func<Func<TA, Func<TB, TC>>, TC>> Apply2<TA, TB, TC>(TA a)
        {
            return b => f => f(a)(b);
        }

        public static Func<Func<TA, Func<TB, TC>>, TC> Apply2<TA, TB, TC>(TA a, TB b)
        {
            return f => f(a)(b);
        }

        public static Func<TB, Func<TC, Func<Func<TA, Func<TB, Func<TC, TD>>>, TD>>> Apply3<TA, TB, TC, TD>(TA a)
        {
            return b => c => f => f(a)(b)(c);
        }

        public static Func<TC, Func<Func<TA, Func<TB, Func<TC, TD>>>, TD>> Apply3<TA, TB, TC, TD>(TA a, TB b)
        {
            return c => f => f(a)(b)(c);
        }

        public static Func<Func<TA, Func<TB, Func<TC, TD>>>, TD> Apply3<TA, TB, TC, TD>(TA a, TB b, TC c)
        {
            return f => f(a)(b)(c);
        }

        public static Func<TB, Func<TC, Func<TD, Func<Func<TA, Func<TB, Func<TC, Func<TD, TE>>>>, TE>>>> Apply4<TA, TB, TC, TD, TE>(TA a)
        {
            return b => c => d => f => f(a)(b)(c)(d);
        }

        public static Func<TC, Func<TD, Func<Func<TA, Func<TB, Func<TC, Func<TD, TE>>>>, TE>>> Apply4<TA, TB, TC, TD, TE>(TA a, TB b)
        {
            return c => d => f => f(a)(b)(c)(d);
        }

        public static Func<TD, Func<Func<TA, Func<TB, Func<TC, Func<TD, TE>>>>, TE>> Apply4<TA, TB, TC, TD, TE>(TA a, TB b, TC c)
        {
            return d => f => f(a)(b)(c)(d);
        }

        public static Func<Func<TA, Func<TB, Func<TC, Func<TD, TE>>>>, TE> Apply4<TA, TB, TC, TD, TE>(TA a, TB b, TC c, TD d)
        {
            return f => f(a)(b)(c)(d);
        }

        public static Func<TB, Func<TC, Func<TD, Func<TE, Func<Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>>, TF>>>>> Apply5<TA, TB, TC, TD, TE, TF>(TA a)
        {
            return b => c => d => e => f => f(a)(b)(c)(d)(e);
        }

        public static Func<TC, Func<TD, Func<TE, Func<Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>>, TF>>>> Apply5<TA, TB, TC, TD, TE, TF>(TA a, TB b)
        {
            return c => d => e => f => f(a)(b)(c)(d)(e);
        }

        public static Func<TD, Func<TE, Func<Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>>, TF>>> Apply5<TA, TB, TC, TD, TE, TF>(TA a, TB b, TC c)
        {
            return d => e => f => f(a)(b)(c)(d)(e);
        }

        public static Func<TE, Func<Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>>, TF>> Apply5<TA, TB, TC, TD, TE, TF>(TA a, TB b, TC c, TD d)
        {
            return e => f => f(a)(b)(c)(d)(e);
        }

        public static Func<Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>>, TF> Apply5<TA, TB, TC, TD, TE, TF>(TA a, TB b, TC c, TD d, TE e)
        {
            return f => f(a)(b)(c)(d)(e);
        }

        #endregion

        #region Compose

        public static Func<Func<TA, TB>, Func<TA, TC>> Compose<TA, TB, TC>(Func<TB, TC> fbc)
        {
            return fab => a => fbc(fab(a));
        }

        public static Func<TA, TC> Compose<TA, TB, TC>(Func<TB, TC> fbc, Func<TA, TB> fab)
        {
            return a => fbc(fab(a));
        }

        public static Func<TA, TD> Compose3<TA, TB, TC, TD>(Func<TC, TD> fcd, Func<TB, TC> fbc, Func<TA, TB> fab)
        {
            return a => fcd(fbc(fab(a)));
        }

        public static Func<TA, TE> Compose4<TA, TB, TC, TD, TE>(Func<TD, TE> fde, Func<TC, TD> fcd, Func<TB, TC> fbc, Func<TA, TB> fab)
        {
            return a => fde(fcd(fbc(fab(a))));
        }

        public static Func<TA, TF> Compose5<TA, TB, TC, TD, TE, TF>(Func<TE, TF> fef, Func<TD, TE> fde, Func<TC, TD> fcd, Func<TB, TC> fbc, Func<TA, TB> fab)
        {
            return a => fef(fde(fcd(fbc(fab(a)))));
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

        #region Flow

        public static Func<Func<TB, TC>, Func<TA, TC>> Flow<TA, TB, TC>(Func<TA, TB> fab)
        {
            return fbc => a => fbc(fab(a));
        }

        public static Func<TA, TC> Flow<TA, TB, TC>(Func<TA, TB> fab, Func<TB, TC> fbc)
        {
            return a => fbc(fab(a));
        }

        public static Func<TA, TD> Flow3<TA, TB, TC, TD>(Func<TA, TB> fab, Func<TB, TC> fbc, Func<TC, TD> fcd)
        {
            return a => fcd(fbc(fab(a)));
        }

        public static Func<TA, TE> Flow4<TA, TB, TC, TD, TE>(Func<TA, TB> fab, Func<TB, TC> fbc, Func<TC, TD> fcd, Func<TD, TE> fde)
        {
            return a => fde(fcd(fbc(fab(a))));
        }

        public static Func<TA, TF> Flow5<TA, TB, TC, TD, TE, TF>(Func<TA, TB> fab, Func<TB, TC> fbc, Func<TC, TD> fcd, Func<TD, TE> fde, Func<TE, TF> fef)
        {
            return a => fef(fde(fcd(fbc(fab(a)))));
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
            return Compose(Not, f);
        }

        public static Func<TA, Func<TB, bool>> Not<TA, TB>(Func<TA, Func<TB, bool>> f)
        {
            return Compose(Not, f);
        }

        public static Func<TA, Func<TB, Func<TC, bool>>> Not<TA, TB, TC>(Func<TA, Func<TB, Func<TC, bool>>> f)
        {
            return Compose(Not, f);
        }

        public static Func<TA, Func<TB, Func<TC, Func<TD, bool>>>> Not<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, Func<TD, bool>>>> f)
        {
            return Compose(Not, f);
        }

        public static Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, bool>>>>> Not<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, bool>>>>> f)
        {
            return Compose(Not, f);
        }

        #endregion

        #region Reverse

        public static Func<TB, Func<TA, TC>> Reverse2<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return Flip(f);
        }

        public static Func<TC, Func<TB, Func<TA, TD>>> Reverse3<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return c => b => a => f(a)(b)(c);
        }

        public static Func<TD, Func<TC, Func<TB, Func<TA, TE>>>> Reverse4<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return d => c => b => a => f(a)(b)(c)(d);
        }

        public static Func<TE, Func<TD, Func<TC, Func<TB, Func<TA, TF>>>>> Reverse5<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return e => d => c => b => a => f(a)(b)(c)(d)(e);
        }

        #endregion

        #region RotateLeft

        public static Func<TB, Func<TA, TC>> RotateLeft2<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return Flip(f);
        }

        public static Func<TB, Func<TC, Func<TA, TD>>> RotateLeft3<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return b => c => a => f(a)(b)(c);
        }

        public static Func<TB, Func<TC, Func<TD, Func<TA, TE>>>> RotateLeft4<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return b => c => d => a => f(a)(b)(c)(d);
        }

        public static Func<TB, Func<TC, Func<TD, Func<TE, Func<TA, TF>>>>> RotateLeft5<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return b => c => d => e => a => f(a)(b)(c)(d)(e);
        }

        #endregion

        #region RotateRight

        public static Func<TB, Func<TA, TC>> RotateRight2<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return Flip(f);
        }

        public static Func<TC, Func<TA, Func<TB, TD>>> RotateRight3<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return c => a => b => f(a)(b)(c);
        }

        public static Func<TD, Func<TA, Func<TB, Func<TC, TE>>>> RotateRight4<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return d => a => b => c => f(a)(b)(c)(d);
        }

        public static Func<TE, Func<TA, Func<TB, Func<TC, Func<TD, TF>>>>> RotateRight5<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return e => a => b => c => d => f(a)(b)(c)(d)(e);
        }

        #endregion

        #region Uncurry

        public static Func<TA, TB, TC> Uncurry2<TA, TB, TC>(Func<TA, Func<TB, TC>> f)
        {
            return (a, b) => f(a)(b);
        }

        public static Func<TA, TB, TC, TD> Uncurry3<TA, TB, TC, TD>(Func<TA, Func<TB, Func<TC, TD>>> f)
        {
            return (a, b, c) => f(a)(b)(c);
        }

        public static Func<TA, TB, TC, TD, TE> Uncurry4<TA, TB, TC, TD, TE>(Func<TA, Func<TB, Func<TC, Func<TD, TE>>>> f)
        {
            return (a, b, c, d) => f(a)(b)(c)(d);
        }

        public static Func<TA, TB, TC, TD, TE, TF> Uncurry5<TA, TB, TC, TD, TE, TF>(Func<TA, Func<TB, Func<TC, Func<TD, Func<TE, TF>>>>> f)
        {
            return (a, b, c, d, e) => f(a)(b)(c)(d)(e);
        }

        #endregion
    }
}
