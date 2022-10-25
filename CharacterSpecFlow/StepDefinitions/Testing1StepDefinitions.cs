using System;
using TechTalk.SpecFlow;

namespace CharacterSpecFlow.StepDefinitions
{
    [Binding]
    public class Testing1StepDefinitions
    {
        [Given(@"The character has an (.*)")]
        public void GivenTheCharacterHasAn(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"Stat is checked")]
        public void WhenStatIsChecked()
        {
            throw new PendingStepException();
        }

        [Then(@"The bonus should be (.*)")]
        public void ThenTheBonusShouldBe(int p0)
        {
            throw new PendingStepException();
        }
    }
}
