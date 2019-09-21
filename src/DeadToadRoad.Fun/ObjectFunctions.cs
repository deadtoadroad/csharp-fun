using System;
using System.Linq;
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

        #region Map

        public static Func<TA, TB> Map<TA, TB>(Func<TA, TB> f)
        {
            return f;
        }

        #endregion

        #region If

        public static Func<TA, Option<TA>> If<TA>(Func<TA, bool> p)
        {
            return a => ToOption(a).Filter(p);
        }

        public static Func<Func<TA, TB>, Func<TA, Option<TB>>> IfMap<TA, TB>(Func<TA, bool> p)
        {
            return f => Compose(OptionMembers.Map(f), If(p));
        }

        public static Func<TA, Option<TB>> IfMap<TA, TB>(Func<TA, bool> p, Func<TA, TB> f)
        {
            return IfMap<TA, TB>(p)(f);
        }

        public static Func<Func<TA, TB>, Func<TA, TB>> IfMapUnsafe<TA, TB>(Func<TA, bool> p)
        {
            return Compose(Compose<TA, Option<TB>, TB>(OptionMembers.GetUnsafe), IfMap<TA, TB>(p));
        }

        public static Func<TA, TB> IfMapUnsafe<TA, TB>(Func<TA, bool> p, Func<TA, TB> f)
        {
            return IfMapUnsafe<TA, TB>(p)(f);
        }

        #endregion

        #region Match

        public static Func<Func<TA, TB>, Func<TA, TB>> Match<TA, TB>(params Func<TA, Option<TB>>[] ifMaps)
        {
            return @else => a => ifMaps
                .Select(Apply<TA, Option<TB>>(a))
                .FirstOrDefault(OptionMembers.IsSome)
                .ToOption()
                .Flatten()
                .GetOrElse(() => @else(a));
        }

        public static Func<TA, TB> MatchUnsafe<TA, TB>(params Func<TA, Option<TB>>[] ifMaps)
        {
            return Match(ifMaps)(_ => default);
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
            return Not<TA, TA>(IsEqual)(v);
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
