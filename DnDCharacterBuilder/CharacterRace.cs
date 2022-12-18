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


        private dynamic RaceArray;

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

        public void SetRace(string name) {
            foreach (var race in RaceArray) {
                if (race.Name == name && race.Campaign == Campaign) {

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
                    Variant = race.Variant;
                    Speed = race.Speed;
                    return;
                }
            }
            
            Console.WriteLine("Race not found. \nPlease ensure that the race was spelled correctly. Capitalization does matter too.");
        }



    }
}
