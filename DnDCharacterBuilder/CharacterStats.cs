namespace DnDCharacterBuilder
{
    public class CharacterStats
    {
        public int Strength { set; get; }   

        public CharacterStats()
        {
            Strength = 0;
        }

        public void SetStat(int score, string stat)
        {
            if (stat == "Strength")
            {
            Strength = score;
            }
        }

        public int GetBonus(string stat)
        {
            int checker=10;
            int bonus;
            if(stat == "Strength")
            {
                checker = Strength;
            }


            if(checker > 10)
            {
                bonus = (checker - 10);
            }
            else
            {
                bonus = checker;
            }


            if (bonus == 0 || bonus == 1)
            {
                bonus = 0;
            }
            else if (bonus == 2 || bonus == 3)
            {
                bonus = 1;
            }
            else if (bonus == 4 || bonus == 5)
            {
                bonus = 2;
            }
            else if (bonus == 6 || bonus == 7)
            {
                bonus = 3;
            }
            else if (bonus == 8 || bonus == 9)
            {
                bonus = 4;
            }
            else if(bonus == 10 || bonus == 11)
            {
                bonus = 5;
            }
            if(Strength < 10)
            {
                bonus *= -1;
            }
            return bonus;   
        }
    }
}