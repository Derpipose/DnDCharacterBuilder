using DnDCharacterBuilder;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace CharacterSpecFlow.StepDefinitions
{
    [Binding]
    public class CharacterMain
    {

        public CharacterMain(ScenarioContext scenarC)
        {
            _sc = scenarC;
        }
        private ScenarioContext _sc;
        Character c = new();

        [Given(@"A new character is made")]
        public void GivenANewCharacterIsMade()
        {
            throw new PendingStepException();
        }

        [When(@"The character's name is Paul")]
        public void WhenTheCharactersNameIsPaul()
        {
            throw new PendingStepException();
        }

        [Then(@"The character's should be Paul")]
        public void ThenTheCharactersShouldBePaul()
        {
            throw new PendingStepException();
        }
    }
}
