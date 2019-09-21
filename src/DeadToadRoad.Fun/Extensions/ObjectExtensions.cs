using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class ObjectExtensions
    {
        #region Identity

        public static TA Identity<TA>(this TA a)
        {
            return Functions.Identity(a);
        }

        #endregion

        #region Map

        public static TB Map<TA, TB>(this TA a, Func<TA, TB> f)
        {
            return Functions.Map(f)(a);
        }

        #endregion

        #region If

        public static Option<TA> If<TA>(this TA a, Func<TA, bool> p)
        {
            return Functions.If(p)(a);
        }

        public static Func<Func<TA, TB>, Option<TB>> IfMap<TA, TB>(this TA a, Func<TA, bool> p)
        {
            return Functions.RotateRight2(Functions.IfMap<TA, TB>(p))(a);
        }

        public static Option<TB> IfMap<TA, TB>(this TA a, Func<TA, bool> p, Func<TA, TB> f)
        {
            return Functions.IfMap(p, f)(a);
        }

        public static Func<Func<TA, TB>, TB> IfMapUnsafe<TA, TB>(this TA a, Func<TA, bool> p)
        {
            return Functions.RotateRight2(Functions.IfMapUnsafe<TA, TB>(p))(a);
        }

        public static TB IfMapUnsafe<TA, TB>(this TA a, Func<TA, bool> p, Func<TA, TB> f)
        {
            return Functions.IfMapUnsafe(p, f)(a);
        }

        #endregion

        #region Match

        public static Func<Func<TA, TB>, TB> Match<TA, TB>(this TA a, params Func<TA, Option<TB>>[] ifMaps)
        {
            return Functions.RotateRight2(Functions.Match(ifMaps))(a);
        }

        public static TB MatchUnsafe<TA, TB>(this TA a, params Func<TA, Option<TB>>[] ifMaps)
        {
            return Functions.MatchUnsafe(ifMaps)(a);
        }

        #endregion

        #region Predicates

        public static bool Is<TA>(this TA a, Func<TA, bool> p)
        {
            return Functions.Is(p)(a);
        }

        public static bool IsNot<TA>(this TA a, Func<TA, bool> p)
        {
            return Functions.IsNot(p)(a);
        }

        public static bool IsEqual<TA>(this TA a, TA v)
            where TA : struct
        {
            return Functions.IsEqual(v)(a);
        }

        public static bool IsNotEqual<TA>(this TA a, TA v)
            where TA : struct
        {
            return Functions.IsNotEqual(v)(a);
        }

        public static bool IsNull<TA>(this TA a)
        {
            return Functions.IsNull(a);
        }

        public static bool IsNotNull<TA>(this TA a)
        {
            return Functions.IsNotNull(a);
        }

        #endregion
    }
}
