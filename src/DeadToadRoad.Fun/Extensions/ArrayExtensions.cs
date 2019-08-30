namespace DeadToadRoad.Fun.Extensions
{
    public static class ArrayExtensions
    {
        public static TA[] Append<TA>(this TA[] target, TA a)
        {
            return ArrayFunctions.Append(a)(target);
        }

        public static TA[] Append<TA>(this TA[] target, params TA[] @as)
        {
            return ArrayFunctions.Append(@as)(target);
        }

        public static TA[] Prepend<TA>(this TA[] target, TA a)
        {
            return ArrayFunctions.Prepend(a)(target);
        }

        public static TA[] Prepend<TA>(this TA[] target, params TA[] @as)
        {
            return ArrayFunctions.Prepend(@as)(target);
        }
    }
}
