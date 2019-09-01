using System;
using System.Collections.Generic;
using DeadToadRoad.Fun.Extensions;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region Identity

        public static TA Identity<TA>(TA a)
        {
            return a;
        }

        #endregion

        #region If

        public static Func<Func<TA, TB>, Func<TA, Option<TB>>> If<TA, TB>(Func<TA, bool> p)
        {
            return f => a => p(a) ? Some(f(a)) : None<TB>();
        }

        public static Func<Func<TA, TB>, Func<TA, Option<TB>>> IfNot<TA, TB>(Func<TA, bool> p)
        {
            return If<TA, TB>(Not(p));
        }

        #endregion

        #region Match

        public static Func<Func<TA, TB>, Func<TA, TB>> Match<TA, TB>(Func<TA, Option<TB>> @if)
        {
            return Match(new[] {@if});
        }

        public static Func<Func<TA, TB>, Func<TA, TB>> Match<TA, TB>(IEnumerable<Func<TA, Option<TB>>> ifs)
        {
            return otherwise => a => {
                foreach (var @if in ifs)
                {
                    var result = @if(a);

                    if (result.IsSome())
                        return result.GetUnsafe();
                }

                return otherwise(a);
            };
        }

        public static Func<TA, TB> MatchUnsafe<TA, TB>(Func<TA, Option<TB>> @if)
        {
            return MatchUnsafe(new[] {@if});
        }

        public static Func<TA, TB> MatchUnsafe<TA, TB>(IEnumerable<Func<TA, Option<TB>>> ifs)
        {
            return Match(ifs)(_ => default);
        }

        #endregion

        #region Predicates

        public static Func<TA, bool> Is<TA>(Func<TA, bool> p)
        {
            return p;
        }

        public static Func<TA, bool> IsNot<TA>(Func<TA, bool> p)
        {
            return Not(p);
        }

        public static Func<TA, bool> IsEqual<TA>(TA v)
        {
            return a => a.Equals(v);
        }

        public static Func<TA, bool> IsNotEqual<TA>(TA v)
        {
            return Not(IsEqual(v));
        }

        public static bool IsNull<TA>(TA a)
        {
            return a == null;
        }

        public static bool IsNotNull<TA>(TA a)
        {
            return Not<TA>(IsNull)(a);
        }

        #endregion
    }
}
