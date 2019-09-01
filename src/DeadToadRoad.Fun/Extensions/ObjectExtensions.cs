using System;
using System.Collections.Generic;

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

        #region If

        public static Func<Func<TA, TB>, Option<TB>> If<TA, TB>(this TA a, Func<TA, bool> p)
        {
            return Functions.Flip(Functions.If<TA, TB>(p))(a);
        }

        public static Func<Func<TA, TB>, Option<TB>> IfNot<TA, TB>(this TA a, Func<TA, bool> p)
        {
            return Functions.Flip(Functions.IfNot<TA, TB>(p))(a);
        }

        #endregion

        #region Match

        public static Func<Func<TA, TB>, TB> Match<TA, TB>(this TA a, Func<TA, Option<TB>> @if)
        {
            return Functions.Flip(Functions.Match(@if))(a);
        }

        public static Func<Func<TA, TB>, TB> Match<TA, TB>(this TA a, IEnumerable<Func<TA, Option<TB>>> ifs)
        {
            return Functions.Flip(Functions.Match(ifs))(a);
        }

        public static TB MatchUnsafe<TA, TB>(this TA a, Func<TA, Option<TB>> @if)
        {
            return Functions.MatchUnsafe(@if)(a);
        }

        public static TB MatchUnsafe<TA, TB>(this TA a, IEnumerable<Func<TA, Option<TB>>> ifs)
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
