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

        public static Func<Func<TA, TB>, Option<TB>> If<TA, TB>(this TA a, Func<TA, bool> p)
        {
            return Functions.Rotate(Functions.If<TA, TB>(p))(a);
        }

        public static Func<Func<TA, TB>, TB> IfUnsafe<TA, TB>(this TA a, Func<TA, bool> p)
        {
            return Functions.Rotate(Functions.IfUnsafe<TA, TB>(p))(a);
        }

        #endregion

        #region Match

        public static Func<Func<TA, TB>, TB> Match<TA, TB>(this TA a, params Func<TA, Option<TB>>[] ifs)
        {
            return Functions.Rotate(Functions.Match(ifs))(a);
        }

        public static TB MatchUnsafe<TA, TB>(this TA a, params Func<TA, Option<TB>>[] ifs)
        {
            return Functions.MatchUnsafe(ifs)(a);
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
