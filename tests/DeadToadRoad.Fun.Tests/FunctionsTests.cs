using System;
using Xbehave;
using Xunit;
using static DeadToadRoad.Fun.Functions;

namespace DeadToadRoad.Fun.Tests
{
    public class FunctionsTests
    {
        #region Not

        [Scenario]
        public void Not_ForBoolWorks(bool a, bool actual)
        {
            "Given false"
                .x(() => a = false);

            "When not is called"
                .x(() => actual = Not(a));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_ForFuncBoolWorks(Func<bool> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = Delay(false));

            "When not is called and the result executed"
                .x(() => actual = Not(f)());

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_ForFunc1BoolWorks(Func<object, bool> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = a => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)(default));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_ForFunc2BoolWorks(Func<object, Func<object, bool>> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = a => b => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)(default)(default));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_ForFunc3BoolWorks(Func<object, Func<object, Func<object, bool>>> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = a => b => c => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)(default)(default)(default));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_ForFunc4BoolWorks(Func<object, Func<object, Func<object, Func<object, bool>>>> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = a => b => c => d => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)(default)(default)(default)(default));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        [Scenario]
        public void Not_ForFunc5BoolWorks(Func<object, Func<object, Func<object, Func<object, Func<object, bool>>>>> f, bool actual)
        {
            "Given a function that returns false"
                .x(() => f = a => b => c => d => e => false);

            "When not is called and the result executed"
                .x(() => actual = Not(f)(default)(default)(default)(default)(default));

            "Then true is returned"
                .x(() => Assert.True(actual));
        }

        #endregion
    }
}
