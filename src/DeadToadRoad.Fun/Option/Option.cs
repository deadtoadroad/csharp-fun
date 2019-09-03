using System;
using System.Collections.Generic;

namespace DeadToadRoad.Fun
{
    public abstract class Option<TA>
    {
        public static None<TA> None { get; } = new None<TA>();

        protected virtual TA A { get; } = default;

        public abstract bool IsSome { get; }
        public abstract bool IsNone { get; }

        public abstract Option<TA> Filter(Func<TA, bool> p);
        public abstract Option<TB> FlatMap<TB>(Func<TA, Option<TB>> f);

        public TA GetOrElse(TA @else)
        {
            return GetOrElse(() => @else);
        }

        public abstract TA GetOrElse(Func<TA> @else);

        public TA GetUnsafe()
        {
            return A;
        }

        public abstract Option<TB> Map<TB>(Func<TA, TB> f);
        public abstract TA[] ToArray();
        public abstract IList<TA> ToList();
    }
}
