namespace DeadToadRoad.Fun.Extensions
{
    public static class ArrayExtensions
    {
        public static TA[] Append<TA>(this TA[] target, TA a)
        {
            return Functions.Append(a)(target);
        }

        public static TA[] Append<TA>(this TA[] target, params TA[] @as)
        {
            return Functions.Append(@as)(target);
        }

        public static TA[] Prepend<TA>(this TA[] target, TA a)
        {
            return Functions.Prepend(a)(target);
        }

        public static TA[] Prepend<TA>(this TA[] target, params TA[] @as)
        {
            return Functions.Prepend(@as)(target);
        }
    }
}
