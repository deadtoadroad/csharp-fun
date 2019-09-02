using System;
using System.Collections.Generic;
using System.Linq;

namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region AppendRange

        public static Func<IEnumerable<TA>, IEnumerable<TA>> AppendRange<TA>(IEnumerable<TA> range)
        {
            return @as => (@as ?? new TA[0])
                .Concat(range ?? new TA[0]);
        }

        public static Func<IEnumerable<TA>, IEnumerable<TA>> PrependRange<TA>(IEnumerable<TA> range)
        {
            return Flip<IEnumerable<TA>, IEnumerable<TA>, IEnumerable<TA>>(AppendRange)(range);
        }

        #endregion
    }
}
