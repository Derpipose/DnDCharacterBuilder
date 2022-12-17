using DnDCharacterBuilder;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace CharacterSpecFlow.StepDefinitions
{
    [Binding]
    public class StatTesting
    {
        public StatTesting(ScenarioContext scenarC)
        {
            _sc = scenarC;
        }
        private ScenarioContext _sc;


        [Given(@"The character has an (.*) in (.*)")]
        public void GivenTheCharacterHasAn(int number, string stat)
        {
            CharacterStats c = new();

            c.SetStat(number, stat);
            _sc.Set<CharacterStats>(c, "stats");
        }

        [Given(@"a (.*) in (.*)")]
        public void GivenAInIntelegence(int number, string stat)
        {
            CharacterStats c = _sc.Get<CharacterStats>("stats");
            c.SetStat(number, stat);
            _sc.Set<CharacterStats>(c, "stats");
        }


        [When(@"(.*) is checked")]
        public void WhenStatIsChecked(string stat)
        {
            CharacterStats c = _sc.Get<CharacterStats>("stats");
            _sc.Add(stat, c.GetBonus(stat));
        }

        [Then(@"The (.*) bonus should be (.*)")]
        public void ThenTheBonusShouldBe(string stat, int bonus)
        {
            _sc.Get<int>(stat).Should().Be(bonus);
        }
    }
}
