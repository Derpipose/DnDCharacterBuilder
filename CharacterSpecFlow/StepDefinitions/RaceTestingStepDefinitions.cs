using System;
using TechTalk.SpecFlow;

namespace CharacterSpecFlow.StepDefinitions
{
    [Binding]
    public class RaceTestingStepDefinitions
    {
        [Then(@"(.*)'s (.*) score should be (.*)")]
        public void ThenBrantsIntelegenceShouldBe(string name, string stat, int score)
        {
            throw new PendingStepException();
        }

        [Then(@"(.*)'s (.*) score should be (.*)")]
        public void ThenBrantsStrengthShouldBe(int p0)
        {
            throw new PendingStepException();
        }

    }
}
