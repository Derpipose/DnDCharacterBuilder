using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterBuilder {
    public class CharacterMain {

        public CharacterMain() {

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
                Console.WriteLine("Current stats are: \n Str: " + character.CharStats.Strength +
                    "\n Con: " + character.CharStats.Constitution + "\n Dex: " + character.CharStats.Dexterity +
                    "\n Int: " + character.CharStats.Intelegence +
                    "\n Wis: " + character.CharStats.Wisdom + "\n Cha: " + character.CharStats.Charasma);

                Console.WriteLine("\n Please enter a stat you would like to edit");
                input = Console.ReadLine();
                if(input != "") {

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
}
