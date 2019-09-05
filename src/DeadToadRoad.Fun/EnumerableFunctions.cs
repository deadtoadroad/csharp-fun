using System;
using System.Collections.Generic;
using System.Linq;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region PrependRange

        public static Func<IEnumerable<TA>, IEnumerable<TA>> PrependRange<TA>(IEnumerable<TA> range)
        {
            return range.Concat;
        }

        #endregion
    }
}
