using System.Collections.Generic;
using System.Linq;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region Flatten

        public static IEnumerable<TA> Flatten<TA>(IEnumerable<Option<TA>> @as)
        {
            return @as.SelectMany(a => a.ToArray());
        }

        public static Option<TA> Flatten<TA>(Option<Option<TA>> a)
        {
            return IsSome(a) ? a.GetUnsafe() : None<TA>();
        }

        #endregion

        #region Factories

        public static Option<TA> Some<TA>(TA a)
        {
            return new Some<TA>(a);
        }

        public static Option<TA> None<TA>()
        {
            return Option<TA>.None;
        }

        #endregion

        #region Predicates

        public static bool IsSome<TA>(Option<TA> a)
        {
            return a is Some<TA>;
        }

        public static bool IsNone<TA>(Option<TA> a)
        {
            return a is None<TA>;
        }

        #endregion
    }
}
