using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DnDCharacterBuilder {
    public class CharacterMain {

        public CharacterMain() {
            LoadCharacters();
        }

        private List<Character> characterlist = new List<Character>();

        public Character SetCharacter() {
            int input = 32;
            string read = "initilized";
            while(read != "") {

                Console.WriteLine("This is all of the availiable Characters. Please select one. Or just hit enter to go back.");
                for (int i = 0; i < characterlist.Count; i++) {
                    string name = characterlist[i].Name;
                    Console.WriteLine(i + ": " + name);
                }
                read = Console.ReadLine();
                try {
                    input = Convert.ToInt32(read);
                } catch {
                    Console.WriteLine("Please enter a valid input.");
                }

                if (input < characterlist.Count) { 
                    return characterlist[input];
                }
            }
            return null;

        }

        public Character NewCharacter() {
            Console.Clear();
            Console.WriteLine("What would you like to name your new character? (Don't worry, you can change the name later) \n");
            string name = Console.ReadLine();
            if ( name != "") {
                Character character = new Character();
                character.SetName(name);
                characterlist.Add(character);
                return character;
            }
            return null;
        }

        public void EditStats(Character character) {
            string input = "initilize";
            int num;
            while (input != "") {
                Console.Clear();
                Console.WriteLine("Press enter to return to the previous page.");
                Console.WriteLine(character.Name + "'s current stats are: \n Str: " + character.CharStats.BaseStrength +
                    "\n Con: " + character.CharStats.BaseConstitution + "\n Dex: " + character.CharStats.BaseDexterity +
                    "\n Int: " + character.CharStats.BaseIntelegence +
                    "\n Wis: " + character.CharStats.BaseWisdom + "\n Cha: " + character.CharStats.BaseCharasma);
                if (character.CharRace.RaceStrength != 0) { Console.WriteLine("Racial bonus to Strength of + " + character.CharRace.RaceStrength); }
                if (character.CharRace.RaceConstitution != 0) { Console.WriteLine("Racial bonus to Constitution of + " + character.CharRace.RaceConstitution); }
                if (character.CharRace.RaceDexterity != 0) { Console.WriteLine("Racial bonus to Dexterity of + " + character.CharRace.RaceDexterity); }
                if (character.CharRace.RaceIntelegence != 0) { Console.WriteLine("Racial bonus to Intelegence of + " + character.CharRace.RaceIntelegence); }
                if (character.CharRace.RaceWisdom != 0) { Console.WriteLine("Racial bonus to Wisdom of + " + character.CharRace.RaceWisdom); }
                if (character.CharRace.RaceCharasma != 0) { Console.WriteLine("Racial bonus to Charasma of + " + character.CharRace.RaceCharasma); }

                if (character.CharRace.Picks.Count > 0) { 
                    Console.WriteLine("You have " + character.CharRace.Picks.Count + " stats you can modify from your race. If you want to place your stat, please type 'RACE'");
                }

                Console.WriteLine("\n Please enter a stat you would like to edit");
                input = Console.ReadLine();
                if(input != "") {
                    if (input == "RACE" || input == "race") { 
                        for(int i = 0; i  < character.CharRace.Picks.Count; i++) {
                            Console.WriteLine("Where would you like the + " + character.CharRace.Picks[i] + "?");
                            input = Console.ReadLine();
                            character.CharRace.SetRaceStat(character.CharRace.Picks[i], input);
                            Console.ReadLine();
                        }
                    } else { 
                        Console.WriteLine("\n What would you like the " + input + " stat to be?");
                        try {
                            num = Int32.Parse(Console.ReadLine());
                        } catch {
                            num = 0;
                        }

                        character.SetStats(num, input);
                    }
                }
            }
        }

        public void EditRace(Character character) {
            string input = "initilize";
            string race;
            while (input != "") {
            if (character.Race != "") {
                race = character.Race;
            } else { 
                race = "unchosen"; }
                Console.Clear();
                Console.WriteLine("Please enter a race from the website. Ensure spelling and capitalization is correct. Or hit enter to go back.");
                Console.WriteLine(character.Name + "'s race is currently: " + race + " " + character.CharRace.Variant);
                input = Console.ReadLine();
                if (input != "") { 
                    character.SetRace(input);
                    input = Console.ReadLine();
                }
            }

        }

        public void EditClass(Character character) {
            string input = "initilize";
            string charclass;
            while (input != "") {
                if (character.ClassName != "") {
                    charclass = character.ClassName;
                } else {
                    charclass = "unchosen";
            }
                Console.Clear();
                Console.WriteLine("Please enter a class from the website. Ensure spelling and capitalization is correct. Or hit enter to go back. ");
                Console.WriteLine(character.Name + "'s class is currently: " + charclass);
                input = Console.ReadLine();
                if(input != "") {

                character.SetClass(input);
                Console.ReadLine();
                }
            }

        }

        public void EditName(Character character) {
            string input = "initilized";
            while (input != "") {
                Console.Clear();
                Console.WriteLine("What would you like " + character.Name + "'s name to be instead?");
                input = Console.ReadLine();
                if (input != "") {
                    character.SetName(input);
                }
            }
        }

        public void DisplayCharacter(Character character) {

        }

        public async void SaveCharacters() {
            string json = "[";
            for(int i =0; i < characterlist.Count(); i++) {

                string characterstring = "{";
                characterstring += "\"Name\": \"" + characterlist[i].Name + "\",\n";
                characterstring += "\"Class\": \"" + characterlist[i].ClassName + "\",\n";
                characterstring += "\"Race\": \"" + characterlist[i].Race + "\",\n";
                characterstring += "\"RaceVariant\": \"" + characterlist[i].CharRace.Variant + "\",\n";
                characterstring += "\"BaseStr\": " + characterlist[i].CharStats.BaseStrength + ",\n";
                characterstring += "\"BaseCon\": " + characterlist[i].CharStats.BaseConstitution + ",\n";
                characterstring += "\"BaseDex\": " + characterlist[i].CharStats.BaseDexterity + ",\n";
                characterstring += "\"BaseInt\": " + characterlist[i].CharStats.BaseIntelegence + ",\n";
                characterstring += "\"BaseWis\": " + characterlist[i].CharStats.BaseWisdom + ",\n";
                characterstring += "\"BaseCha\": " + characterlist[i].CharStats.BaseCharasma + ",\n";
                characterstring += "\"RaceStr\": " + characterlist[i].CharRace.RaceStrength + ",\n";
                characterstring += "\"RaceCon\": " + characterlist[i].CharRace.RaceConstitution + ",\n";
                characterstring += "\"RaceDex\": " + characterlist[i].CharRace.RaceDexterity + ",\n";
                characterstring += "\"RaceInt\": " + characterlist[i].CharRace.RaceIntelegence + ",\n";
                characterstring += "\"RaceWis\": " + characterlist[i].CharRace.RaceWisdom + ",\n";
                characterstring += "\"RaceCha\": " + characterlist[i].CharRace.RaceCharasma + ",\n";


                characterstring += "}";
                json += characterstring;
            }
            json += "]";
            await File.WriteAllTextAsync("C:\\Users\\thefl\\source\\repos\\DnDCharacterBuilder\\DnDCharacterBuilder\\Characters.json", json);
        }

        public void LoadCharacters() {
            dynamic characterarray;
            using (StreamReader r = new StreamReader("C:\\Users\\thefl\\source\\repos\\DnDCharacterBuilder\\DnDCharacterBuilder\\Characters.json")) {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                characterarray = array;
            }
            if (characterarray != null) {
                foreach (var character in characterarray) {
                    Character newchar = new();
                    string name = character.Name;
                    newchar.SetName(name);
                    string loadclass = character.Class;
                    newchar.CharClass.LoadClass(loadclass);
                    string race = character.Race;
                    string racevar = character.RaceVariant;
                    newchar.CharRace.LoadRace(race, racevar);
                    int str = character.BaseStr;
                    int dex = character.BaseDex;
                    int con = character.BaseCon;
                    int inte = character.BaseInt;
                    int wis = character.BaseWis;
                    int cha = character.BaseCha;
                    newchar.CharStats.LoadStats(str, dex, con, inte, wis, cha);
                    /*newchar.CharRace.LoadStats(Int32.Parse(character.RaceStr), Int32.Parse(character.RaceDex), Int32.Parse(character.RaceCon), Int32.Parse(character.RaceInt), Int32.Parse(character.RaceWis), Int32.Parse(character.RaceCha));
*/
                    str = character.RaceStr;
                    dex = character.RaceDex;
                    con = character.RaceCon;
                    inte =character.RaceInt;
                    wis = character.RaceWis;
                    cha = character.RaceCha;
                    newchar.CharRace.LoadStats(str, dex, con, inte, wis, cha);

                    characterlist.Add(newchar);
                }
            }
        }

    }
}
