using System;
using System.Collections.Generic;

namespace DeadToadRoad.Fun
{
    public class None<TA> : Option<TA>
    {
        internal None()
        {
        }

        public override bool IsSome => false;
        public override bool IsNone => true;

        public override Option<TB> FlatMap<TB>(Func<TA, Option<TB>> f)
        {
            return Functions.None<TB>();
        }

        public override TA GetOrElse(TA @else)
        {
            return @else;
        }

        public override Option<TB> Map<TB>(Func<TA, TB> f)
        {
            return Functions.None<TB>();
        }

        public override TA[] ToArray()
        {
            return new TA[0];
        }

        public override IList<TA> ToList()
        {
            return new List<TA>();
        }
    }
}
