using static DeadToadRoad.Fun.Option.OptionFunctions;
using static DeadToadRoad.Fun.Functions;
using static DeadToadRoad.Fun.ObjectFunctions;

namespace DeadToadRoad.Fun.Option
{
    public abstract class Option<TA>
    {
        public static None<TA> None { get; } = new None<TA>();

        protected virtual TA A { get; } = default;

        public abstract bool IsSome { get; }
        public bool IsNone => Not(IsSome);

        public static Option<TA> From(TA a)
        {
            return IsNotNull(a) ? (Option<TA>) Some(a) : None;
        }

        public static implicit operator Option<TA>(TA a)
        {
            return From(a);
        }

        public static implicit operator TA(Option<TA> option)
        {
            return option.A;
        }
    }
}
