using System;
using TechTalk.SpecFlow;

namespace CharacterSpecFlow.StepDefinitions
{
    [Binding]
    public class RaceTestingStepDefinitions
    {
        [Then(@"Brant's Intelegence should be (.*)")]
        public void ThenBrantsIntelegenceShouldBe(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"Brant's Strength should be (.*)")]
        public void ThenBrantsStrengthShouldBe(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"Brant's Constitution should be (.*)")]
        public void ThenBrantsConstitutionShouldBe(int p0)
        {
            throw new PendingStepException();
        }
    }
}
