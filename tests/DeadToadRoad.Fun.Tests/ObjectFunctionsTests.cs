using System;
using Xbehave;
using Xunit;
using static DeadToadRoad.Fun.Functions;
using static DeadToadRoad.Fun.OptionFunctions;

namespace DeadToadRoad.Fun.Tests
{
    public class ObjectFunctionsTests
    {
        #region Match

        [Scenario]
        public void Match_IfElseEvaluationCheck(bool if2Called, bool elseCalled, Func<int, Option<int>> if1, Func<int, Option<int>> if2, Func<int, int> @else)
        {
            "Given two ifs and an else"
                .x(() => {
                    if2Called = false;
                    elseCalled = false;
                    if1 = _ => Some(1);
                    if2 = _ => {
                        if2Called = true;
                        return Some(2);
                    };
                    @else = _ => {
                        elseCalled = true;
                        return 3;
                    };
                });

            "When match is called and the first if produces a result"
                .x(() => Match(if1, if2)(@else)(0));

            "Then the second if is not evaluated"
                .x(() => Assert.False(if2Called));

            "And the else is not evaluated"
                .x(() => Assert.False(elseCalled));
        }

        #endregion
    }
}
