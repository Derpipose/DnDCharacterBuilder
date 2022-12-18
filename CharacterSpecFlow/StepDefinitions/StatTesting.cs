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


        [Given(@"The character has a (.*) in (.*)")]
        public void GivenTheCharacterHasA(int number, string stat)
        {
            CharacterStats c = new();
            CharacterRace race = new CharacterRace();   
            c.SetStat(number, stat, race);
            _sc.Set<CharacterStats>(c, "stats");
        }

        [Given(@"a (.*) in (.*)")]
        public void GivenAInIntelegence(int number, string stat)
        {
            CharacterStats c = _sc.Get<CharacterStats>("stats");
            CharacterRace race = new CharacterRace();
            c.SetStat(number, stat, race);
            _sc.Set<CharacterStats>(c, "stats");
        }

        [When(@"(.*) has a (.*) in (.*)")]
        public void WhenHasAIn(string name, int number, string stat)
        {
            Character c = _sc.Get<Character>(name);
            CharacterRace race = c.CharRace;
            c.CharStats.SetStat(number, stat, race);
            _sc.Set<Character>(c, name);
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

        [Then(@"(.*) has a (.*) in (.*)")]
        public void ThenHasAIn(string name, int number, string stat)
        {
            Character c = _sc.Get<Character>(name);
            if (stat == "Constitution")
            {
                c.CharStats.Constitution.Should().Be(number);
            }
            else if (stat == "Intelegence")
            {
                c.CharStats.Intelegence.Should().Be(number);
            }
            else if (stat == "Strength")
            {
                c.CharStats.Strength.Should().Be(number);
            }
            else if (stat == "Dexterity")
            {
                c.CharStats.Dexterity.Should().Be(number);
            }
            else if (stat == "Wisdom")
            {
                c.CharStats.Wisdom.Should().Be(number);
            }
            else if (stat == "Charasma")
            {
                c.CharStats.Charasma.Should().Be(number);
            }
            else return;
                
        }

    }
}
