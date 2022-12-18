using static System.Formats.Asn1.AsnWriter;

namespace DnDCharacterBuilder
{
    public class CharacterStats
    {

        public int Strength { private set; get; }
        public int Constitution { private set; get; }
        public int Dexterity { private set; get; }
        public int Intelegence { private set; get; }
        public int Wisdom { private set; get; }
        public int Charasma { private set; get; }
        private int BaseStrength { set; get; }
        private int BaseConstitution {  set; get; }
        private int BaseDexterity {  set; get; }
        private int BaseIntelegence {  set; get; }
        private int BaseWisdom {  set; get; }
        private int BaseCharasma {  set; get; }

        public int Health { private set; get; }
        public int Mana { private set; get; }


        public CharacterStats()
        {
            Strength = 0;
            Intelegence = 0;
            Constitution = 0;
            Dexterity = 0;
            Wisdom = 0;
            Charasma = 0;

            BaseStrength = 0;
            BaseIntelegence = 0;
            BaseConstitution = 0;
            BaseDexterity = 0;
            BaseWisdom = 0;
            BaseCharasma = 0;

            

        }

        public void SetStat(int score, string stat, CharacterRace race)
        {
            if (stat == "Strength")
            {
                BaseStrength = score;
                Strength = BaseStrength + race.RaceStrength;
            }
            if (stat == "Intelegence")
            {
                BaseIntelegence = score;
                Intelegence = BaseIntelegence + race.RaceIntelegence;
            }
            if (stat == "Wisdom")
            {
                BaseWisdom = score;
                Wisdom = BaseWisdom + race.RaceWisdom;
            }
            if (stat == "Dexterity")
            {
                BaseDexterity = score;
                Dexterity = BaseDexterity + race.RaceDexterity;  
            }
            if (stat == "Constitution")
            {
                BaseConstitution = score;
                Constitution = BaseConstitution + race.RaceConstitution; 
            }
            if (stat == "Charasma")
            {
                BaseCharasma = score;
                Charasma = BaseCharasma + race.RaceCharasma; 
            }
        }

        public void UpdateStats(CharacterRace race, CharacterClass charClass) {
            Strength = BaseStrength + race.RaceStrength;
            Constitution = BaseConstitution + race.RaceConstitution;
            Dexterity = BaseDexterity + race.RaceDexterity;
            Intelegence = BaseIntelegence + race.RaceIntelegence;
            Wisdom = BaseWisdom + race.RaceWisdom;
            Charasma = BaseCharasma + race.RaceCharasma;
            if (charClass.ClassType == "Combat") {
                Health = (2 * Constitution + charClass.HitDie + GetBonus("Constitution"));
                if(race.AddOrMultMana == "Mult") {
                    if (Intelegence <= Wisdom) {
                        Mana = (Wisdom * race.BonusMana + (2 * charClass.ManaDie) + GetBonus("Wisdom"));
                    } else {
                        Mana = (Intelegence * race.BonusMana + (2 * charClass.ManaDie) + GetBonus("Intelegence"));
                    }
                } else {

                    if (Intelegence <= Wisdom) {
                        Mana = (Wisdom + (2 * charClass.ManaDie) + GetBonus("Wisdom") + race.BonusMana);
                    } else {
                        Mana = (Intelegence + (2 * charClass.ManaDie) + GetBonus("Intelegence") + race.BonusMana);
                    }
                }
            } else {
                Health = ((2 * charClass.HitDie) + Constitution + GetBonus("Constitution"));
                if (race.AddOrMultMana != "Mult") {
                    if (Intelegence <= Wisdom) {
                        Mana = Intelegence + Wisdom + GetBonus("Wisdom") + race.BonusMana;
                    } else {
                        Mana = Intelegence + Wisdom + GetBonus("Intelegence") + race.BonusMana;
                    }
                } else {
                    if (Intelegence <= Wisdom) {
                        Mana = (Wisdom * race.BonusMana) + Intelegence + charClass.ManaDie + GetBonus("Wisdom");
                    } else {
                        Mana = (Intelegence * race.BonusMana) + Wisdom + charClass.ManaDie + GetBonus("Intelegence");
                    }
                }

            }
        }



        public int GetBonus(string stat)
        {
            int checker=0;
            int bonus=0;
            if(stat == "Strength")
            {
                checker = Strength;
            }
            else if(stat == "Intelegence")
            {
                checker = Intelegence;
            }
            else if (stat == "Wisdom")
            {
                checker = Wisdom;
            }
            else if (stat == "Dexterity")
            {
                checker = Dexterity;
            }
            else if (stat == "Constitution")
            {
                checker = Constitution ;
            }
            else if (stat == "Charasma")
            {
                checker = Charasma;
            }


            if (checker <= 3)
            {
                bonus = -4;
            }
            else if( checker == 4 || checker == 5)
            {
                bonus = -3;
            }
            else if(checker == 6 || checker == 7)
            {
                bonus = -2;
            }
            else if(checker <= 8 || checker == 9)
            {
                bonus = -1;
            }
            else if (checker == 10 || checker == 11)
            {
                bonus = 0;
            }
            else if (checker == 12 || checker == 13)
            {
                bonus = 1;
            }
            else if (checker == 14 || checker == 15)
            {
                bonus = 2;
            }
            else if (checker == 16 || checker == 17)
            {
                bonus = 3;
            }
            else if (checker == 18 || checker == 19)
            {
                bonus = 4;
            }
            else if(checker == 20 || checker == 21)
            {
                bonus = 5;
            }
            return bonus;   
        }
    }
}