using DnDCharacterBuilder;
using System;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace CharacterSpecFlow.StepDefinitions
{
    [Binding]
   
    public class ClassTestingStepDefinitions
    { 
        
        
        public ClassTestingStepDefinitions(ScenarioContext scenarC) {
        _sc = scenarC;
        }
    private ScenarioContext _sc;
        [Then(@"(.*)'s (.*) die should be (.*)")]
        public void ThenBrantsHitDieShouldBe(string name, string die, int number)
        {
            Character c = _sc.Get<Character>(name);
            if(die == "hit") {
            c.CharClass.HitDie.Should().Be(number);
            }
            if(die == "mana") {
                c.CharClass.ManaDie.Should().Be(number);
            }

        }
    }
}
