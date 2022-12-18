using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterBuilder
{
    public class Character
    {
        public Character()
        {
            Name = "";
            Race = "";
            ClassName = "";
        }
        public string Name { get; private set; }
        public string Race { get; private set; }
        public string ClassName { get; private set; }
        public CharacterStats CharStats = new();
        public CharacterRace CharRace = new();

        public void SetName(string name)
        {
            Name = name;
        }
        public void SetRace(string race)
        {
            Race = race;
            CharRace.SetRace(race);
            CharStats.UpdateStats(CharRace);
        }
        public void SetClass(string classinfo)
        {
            ClassName = classinfo;
        }
    }
}
