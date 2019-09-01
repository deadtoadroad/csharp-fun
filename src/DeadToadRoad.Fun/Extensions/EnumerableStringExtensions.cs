using System.Collections.Generic;

namespace DeadToadRoad.Fun.Extensions
{
    public static class EnumerableStringExtensions
    {
        #region Join

        public static string Join(this IEnumerable<string> @as, string separator)
        {
            return Functions.Join(separator)(@as);
        }

        public static string JoinDash(this IEnumerable<string> @as)
        {
            return Functions.JoinDash(@as);
        }

        public static string JoinEmpty(this IEnumerable<string> @as)
        {
            return Functions.JoinEmpty(@as);
        }

        public static string JoinSpace(this IEnumerable<string> @as)
        {
            return Functions.JoinSpace(@as);
        }

        #endregion
    }
}
