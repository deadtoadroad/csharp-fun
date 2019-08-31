namespace DeadToadRoad.Fun.Option
{
    public class None<TA> : Option<TA>
    {
        internal None()
        {
        }

        public override bool IsSome => false;
    }
}
