using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DnDCharacterBuilder {
    public class CharacterRace {

        public int RaceStrength { private set; get; }
        public int RaceConstitution { private set; get; }
        public int RaceDexterity { private set; get; }
        public int RaceIntelegence { private set; get; }
        public int RaceWisdom { private set; get; }
        public int RaceCharasma { private set; get; }
        public string RaceName { private set; get; }
        public int BonusMana { private set; get; }
        public string AddOrMultMana { private set; get; }
        public string Variant { private set; get; }
        public int Speed { private set; get; }
        public string Campaign = "Fantasy";


        public List<int> Picks = new();
        private dynamic RaceArray;
        private dynamic VarRaceArray;

        public CharacterRace() {
            RaceStrength = 0;
            RaceIntelegence = 0;
            RaceConstitution = 0;
            RaceDexterity = 0;
            RaceWisdom = 0;
            RaceCharasma = 0;
            BonusMana = 0;
            RaceName = "";
            LoadJson();
        }
        public void LoadJson() {
            using (StreamReader r = new StreamReader("C:\\Users\\thefl\\source\\repos\\DnDCharacterBuilder\\DnDCharacterBuilder\\Races.json")) {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                RaceArray = array;
            }
        }

        public void LoadVarRaceJson() {
            using (StreamReader r = new StreamReader("C:\\Users\\thefl\\source\\repos\\DnDCharacterBuilder\\DnDCharacterBuilder\\VariantRaces.json")) {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                VarRaceArray = array;
            }
        }

        public void SetRace(string name) {
            foreach (var race in RaceArray) {
                if (race.Name == name && race.Campaign == Campaign) {
                    Console.WriteLine("Race Set as " + name + "\n Please hit enter to continue or enter a different race to set.");
                    try {
                        RaceStrength = race.Str;
                    } catch{
                        RaceStrength = 0;
                    }
                    try {
                        RaceConstitution = race.Con;
                    } catch {
                        RaceConstitution = 0;
                    }
                    try {
                        RaceDexterity = race.Dex;
                    } catch {
                        RaceDexterity = 0;
                    }
                    try {
                        RaceWisdom = race.Wis;
                    } catch {
                        RaceWisdom = 0;
                    }
                    try { 
                        RaceCharasma = race.Cha;
                    }
                    catch {
                        RaceCharasma= 0;
                    }
                    try {
                        RaceIntelegence = race.Int;
                    } catch {
                        RaceIntelegence = 0;
                    }
                    RaceName = name;
                    try {
                        BonusMana = race.BonusMana;
                    } catch {
                        BonusMana = 0;
                    }
                    AddOrMultMana = race.AddOrMultMana;
                    Variant = "";
                    Speed = race.Speed;
                    if (race.Pick == "1") {
                        Picks.Add(1);
                    } else if (race.Pick == "2") {
                        Picks.Add(2);
                    } else if(race.Pick == "Both") {
                        Picks.Add(1);
                        Picks.Add(2);
                    } else if(race.Pick == "Race") {
                        SetVarRace(name);
                    }
                    return;
                }
            }
            
            Console.WriteLine("Race not found. \nPlease ensure that the race was spelled correctly. Capitalization does matter too.");
        }

        public void SetVarRace(string name) {


            Console.WriteLine("This race has several subsets. Here are some quick options that we have already done up.\n" + name + " variants are:");
            LoadVarRaceJson();
            foreach( var race in VarRaceArray) {
                if ( race.Race == name) {
                    Console.WriteLine(race.Variant);
                }
            }
            string input = "";
            Console.WriteLine("Please select one of the subtypes to continue. Remember to spell it all out, spelled correctly and capitalized the same.");
            bool raceSet = false;
            while (raceSet == false) {
                input = Console.ReadLine();
                foreach (var race in VarRaceArray) {
                    if (race.Race == name && race.Variant == input) {
                        Console.WriteLine("Race Set as " + name + "\n Please hit enter to continue or enter a different race to set.");
                        try {
                            RaceStrength = race.Str;
                        } catch {
                            RaceStrength = 0;
                        }
                        try {
                            RaceConstitution = race.Con;
                        } catch {
                            RaceConstitution = 0;
                        }
                        try {
                            RaceDexterity = race.Dex;
                        } catch {
                            RaceDexterity = 0;
                        }
                        try {
                            RaceWisdom = race.Wis;
                        } catch {
                            RaceWisdom = 0;
                        }
                        try {
                            RaceCharasma = race.Cha;
                        } catch {
                            RaceCharasma = 0;
                        }
                        try {
                            RaceIntelegence = race.Int;
                        } catch {
                            RaceIntelegence = 0;
                        }
                        RaceName = name;
                        try {
                            BonusMana = race.BonusMana;
                        } catch {
                            BonusMana = 0;
                        }
                        AddOrMultMana = race.AddOrMultMana;
                        Variant = race.Variant;
                        if (race.Pick == "1") {
                            Picks.Add(1);
                        } else if (race.Pick == "2") {
                            Picks.Add(2);
                        } else if (race.Pick == "Both") {
                            Picks.Add(1);
                            Picks.Add(2);
                        }
                        try { Speed = Int32.Parse(race.SpeedOverride); } catch { }

                        raceSet = true;
                    }
                }

                if(raceSet == false) {
                    Console.WriteLine("The race subtype was not found. Please ensure proper spelling and capitalization, picking something from the predone list.");
                }

            }
        }

        public void SetRaceStat(int score, string stat) {
            bool statset = false;
            while (statset == false) {

                if ((stat == "Strength" || stat == "Str" || stat == "str") && RaceStrength == 0) {
                    RaceStrength = score;
                    Console.WriteLine("Racial Strength bonus set to " + score);
                    statset = true;
                } else if ((stat == "Intelegence" || stat == "Int" || stat == "int") && RaceIntelegence == 0) {
                    RaceIntelegence = score;
                    Console.WriteLine("Racial Intelegence bonus set to " + score);
                    statset = true;
                } else if ((stat == "Wisdom" || stat == "Wis" || stat == "wis") && RaceWisdom == 0) {
                    RaceWisdom = score;
                    Console.WriteLine("Racial Wisdom bonus set to " + score);
                    statset = true;
                } else if ((stat == "Dexterity" || stat == "Dex" || stat == "dex") && RaceDexterity == 0) {
                    RaceDexterity = score;
                    Console.WriteLine("Racial Dexterity bonus set to " + score);
                    statset = true;
                } else if ((stat == "Constitution" || stat == "Con" || stat == "con") && RaceConstitution == 0) {
                    RaceConstitution = score;
                    Console.WriteLine("Racial Constitution bonus set to " + score);
                    statset = true;
                } else if ((stat == "Charasma" || stat == "Cha" || stat == "cha") && RaceCharasma == 0) {
                    RaceCharasma = score;
                    Console.WriteLine("Racial Charasma bonus set to " + score);
                    statset = true;
                } else {
                    Console.WriteLine("Please ensure proper spelling or abreviation and try again. Also ensure that a bonus is not already applied to that stat. (They can not stack) Please enter a different stat.");
                    stat = Console.ReadLine();
                }
                if (statset == true) {
                    for (int i = 0; i < Picks.Count(); i++) {
                        if (Picks[i] == score) {
                            Picks.RemoveAt(i);
                        }
                    }
                }

            }

        }

        public void LoadRace(string name, string var) {
            foreach (var race in RaceArray) {
                if (race.Name == name && race.Campaign == Campaign) {
                    Console.WriteLine("Race Set as " + name + "\n Please hit enter to continue or enter a different race to set.");
                    try {
                        RaceStrength = race.Str;
                    } catch {
                        RaceStrength = 0;
                    }
                    try {
                        RaceConstitution = race.Con;
                    } catch {
                        RaceConstitution = 0;
                    }
                    try {
                        RaceDexterity = race.Dex;
                    } catch {
                        RaceDexterity = 0;
                    }
                    try {
                        RaceWisdom = race.Wis;
                    } catch {
                        RaceWisdom = 0;
                    }
                    try {
                        RaceCharasma = race.Cha;
                    } catch {
                        RaceCharasma = 0;
                    }
                    try {
                        RaceIntelegence = race.Int;
                    } catch {
                        RaceIntelegence = 0;
                    }
                    RaceName = name;
                    try {
                        BonusMana = race.BonusMana;
                    } catch {
                        BonusMana = 0;
                    }
                    AddOrMultMana = race.AddOrMultMana;
                    Variant = "";
                    Speed = race.Speed;
                    if (race.Pick == "1") {
                        Picks.Add(1);
                    } else if (race.Pick == "2") {
                        Picks.Add(2);
                    } else if (race.Pick == "Both") {
                        Picks.Add(1);
                        Picks.Add(2);
                    } else if (race.Pick == "Race") {
                        loadVarRace(name, var);
                    }
                    return;
                }
            }

            Console.WriteLine("Race not found. \nPlease ensure that the race was spelled correctly. Capitalization does matter too.");
        }

        public void loadVarRace(string name, string var) {


            bool raceSet = false;
            while (raceSet == false) {
                foreach (var race in VarRaceArray) {
                    if (race.Race == name && race.Variant == var) {
                        try {
                            RaceStrength = race.Str;
                        } catch {
                            RaceStrength = 0;
                        }
                        try {
                            RaceConstitution = race.Con;
                        } catch {
                            RaceConstitution = 0;
                        }
                        try {
                            RaceDexterity = race.Dex;
                        } catch {
                            RaceDexterity = 0;
                        }
                        try {
                            RaceWisdom = race.Wis;
                        } catch {
                            RaceWisdom = 0;
                        }
                        try {
                            RaceCharasma = race.Cha;
                        } catch {
                            RaceCharasma = 0;
                        }
                        try {
                            RaceIntelegence = race.Int;
                        } catch {
                            RaceIntelegence = 0;
                        }
                        RaceName = name;
                        try {
                            BonusMana = race.BonusMana;
                        } catch {
                            BonusMana = 0;
                        }
                        AddOrMultMana = race.AddOrMultMana;
                        Variant = race.Variant;
                        if (race.Pick == "1") {
                            Picks.Add(1);
                        } else if (race.Pick == "2") {
                            Picks.Add(2);
                        } else if (race.Pick == "Both") {
                            Picks.Add(1);
                            Picks.Add(2);
                        }
                        try { Speed = Int32.Parse(race.SpeedOverride); } catch { }

                        raceSet = true;
                    }
                }

            }
        }

        public void LoadStats(int strength, int dexterity, int constitution, int intelegence, int wisdom, int charasma) {
            RaceStrength = strength;
            RaceDexterity = dexterity;
            RaceConstitution = constitution;
            RaceIntelegence = intelegence;
            RaceWisdom = wisdom;
            RaceCharasma = charasma;

        }

    }
}
