using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterBuilder
{
    public class CharacterRace
    {

        public int RaceStrength { private set; get; }
        public int RaceConstitution { private set; get; }
        public int RaceDexterity { private set; get; }
        public int RaceIntelegence { private set; get; }
        public int RaceWisdom { private set; get; }
        public int RaceCharasma { private set; get; }

        public CharacterRace()
        {
            RaceStrength = 0;
            RaceIntelegence = 0;
            RaceConstitution = 0;
            RaceDexterity = 0;
            RaceWisdom = 0;
            RaceCharasma = 0;
        }
    }
}
