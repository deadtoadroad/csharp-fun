using System;
using static DeadToadRoad.Fun.ObjectFunctions;

namespace DeadToadRoad.Fun.Option
{
    public class Some<TA> : Option<TA>
    {
        public Some(TA a)
        {
            A = IsNotNull(a) ? a : throw new ArgumentNullException(nameof(a));
        }

        protected override TA A { get; }

        public override bool IsSome => true;
    }
}
