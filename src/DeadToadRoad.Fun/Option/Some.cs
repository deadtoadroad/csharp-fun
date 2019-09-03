using System;
using System.Collections.Generic;

namespace DeadToadRoad.Fun
{
    public class Some<TA> : Option<TA>
    {
        public Some(TA a)
        {
            A = Functions.IsNotNull(a) ? a : throw new ArgumentNullException(nameof(a));
        }

        protected override TA A { get; }

        public override bool IsSome => true;
        public override bool IsNone => false;

        public override Option<TA> Filter(Func<TA, bool> p)
        {
            return p(A) ? this : Functions.None<TA>();
        }

        public override Option<TB> FlatMap<TB>(Func<TA, Option<TB>> f)
        {
            return f(A);
        }

        public override TA GetOrElse(TA @else)
        {
            return A;
        }

        public override Option<TB> Map<TB>(Func<TA, TB> f)
        {
            return Functions.Some(f(A));
        }

        public override TA[] ToArray()
        {
            return new[] {A};
        }

        public override IList<TA> ToList()
        {
            return new List<TA> {A};
        }
    }
}
