using System;
using System.Collections.Generic;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        private const string Dash = "-";
        private const string Space = " ";

        #region Join

        public static Func<IEnumerable<string>, string> Join(string separator)
        {
            return Curry<string, IEnumerable<string>, string>(string.Join)(separator);
        }

        public static string JoinDash(IEnumerable<string> @as)
        {
            return Join(Dash)(@as);
        }

        public static string JoinEmpty(IEnumerable<string> @as)
        {
            return Join(string.Empty)(@as);
        }

        public static string JoinSpace(IEnumerable<string> @as)
        {
            return Join(Space)(@as);
        }

        #endregion
    }
}
