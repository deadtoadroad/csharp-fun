using System;

namespace DeadToadRoad.Fun.Extensions
{
    public static class FunctionsExtensions
    {
        #region Compose

        public static Func<Func<TA, TB>, TC> Compose<TA, TB, TC>(this TA a, Func<TB, TC> fbc)
        {
            return Functions.RotateRight2(Functions.Compose<TA, TB, TC>(fbc))(a);
        }

        public static TC Compose<TA, TB, TC>(this TA a, Func<TB, TC> fbc, Func<TA, TB> fab)
        {
            return Functions.Compose(fbc, fab)(a);
        }

        #endregion
    }
}
