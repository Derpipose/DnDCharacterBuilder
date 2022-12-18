using DnDCharacterBuilder;
using System;
using TechTalk.SpecFlow;

namespace CharacterSpecFlow.StepDefinitions
{
    [Binding]
    public class RaceTestingStepDefinitions
    {
        public RaceTestingStepDefinitions(ScenarioContext scenarC) {
            _sc = scenarC;
        }
        private ScenarioContext _sc;

        [Then(@"(.*)'s (.*) score should be (.*)")]
        public void ThensShouldBe(string name, string stat, int number)
        {

            Character c = _sc.Get<Character>(name);
            if (stat == "Constitution") {
                c.CharStats.Constitution.Should().Be(number);
            } else if (stat == "Intelegence") {
                c.CharStats.Intelegence.Should().Be(number);
            } else if (stat == "Strength") {
                c.CharStats.Strength.Should().Be(number);
            } else if (stat == "Dexterity") {
                c.CharStats.Dexterity.Should().Be(number);
            } else if (stat == "Wisdom") {
                c.CharStats.Wisdom.Should().Be(number);
            } else if (stat == "Charasma") {
                c.CharStats.Charasma.Should().Be(number);
            } else return;

        }

    }
}
