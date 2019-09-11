namespace DeadToadRoad.Fun
{
    public static partial class OptionMembers
    {
        public static Option<TA> Flatten<TA>(Option<Option<TA>> a)
        {
            return a.FlatMap(Functions.Identity);
        }
    }
}
