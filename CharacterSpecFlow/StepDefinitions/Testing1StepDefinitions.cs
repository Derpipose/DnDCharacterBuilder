using DnDCharacterBuilder;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace CharacterSpecFlow.StepDefinitions
{
    [Binding]
    public class Testing1StepDefinitions
    {
        public Testing1StepDefinitions(ScenarioContext scenarC)
        {
            _sc = scenarC;
        }
        private ScenarioContext _sc;

            CharacterStats c = new();

        [Given(@"The character has an (.*) in (.*)")]
        public void GivenTheCharacterHasAn(int number, string stat)
        {
            c.SetStat(number, stat);
        }

        [When(@"(.*) is checked")]
        public void WhenStatIsChecked(string stat)
        {
            _sc.Add("bonus", c.GetBonus(stat));
        }

        [Then(@"The bonus should be (.*)")]
        public void ThenTheBonusShouldBe(int bonus)
        {
            _sc.Get<int>("bonus").Should().Be(bonus);
        }
    }
}
