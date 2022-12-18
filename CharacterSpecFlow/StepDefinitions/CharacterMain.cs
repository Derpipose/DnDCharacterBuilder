using DnDCharacterBuilder;
using System;
using System.Xml.Linq;
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

        [Given(@"A new character is made")]
        public void GivenANewCharacterIsMade()
        {
            Character c = new();
            _sc.Set<Character>(c, "new");
        }

        [When(@"The character's name is (.*)")]
        public void WhenTheCharactersNameIs(string name)
        {
            Character c = _sc.Get<Character>("new");
            c.SetName(name);
            _sc.Set<Character>(c, name);

        }

        [When(@"(.*)'s race is (.*)")]
        public void WhensRaceIs(string name, string race)
        {
            Character c = _sc.Get<Character>(name);
            c.SetRace(race);
            _sc.Set<Character>(c, name);
        }

        [When(@"(.*)'s class is (.*)")]
        public void WhensClassIs(string name, string classname)
        {
            Character c = _sc.Get<Character>(name);
            c.SetClass(classname);
            _sc.Set<Character>(c, name);
        }

        [When(@"(.*) is renamed to (.*)")]
        public void WhenIsRenamedTo(string oldName, string newName)
        {
            Character c = _sc.Get<Character>(oldName);
            c.SetName(newName);
            _sc.Set<Character>(c, newName);
        }

        [Then(@"(.*)'s race should be (.*)")]
        public void ThensRaceShouldBe(string name, string check)
        {
            Character c = _sc.Get<Character>(name);
            c.Race.Should().Be(check);
        }

        [Then(@"(.*)'s class should be (.*)")]
        public void ThensClassShouldBe(string name, string check)
        {
            Character c = _sc.Get<Character>(name);
            c.CharClass.ClassName.Should().Be(check);
            /*c.ClassName.Should().Be(check);*/
        }


        [Then(@"(.*)'s name should be (.*)")]
        public void ThencharactersNameShouldBe(string name, string check)
        {
            Character c = _sc.Get<Character>(name);
            c.Name.Should().Be(check);
        }

    }
}
