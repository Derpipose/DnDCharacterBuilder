using DnDCharacterBuilder;
using System;

string input = "initilization";
int option = 0;
Character CurrentCharacter = null;
CharacterMain running = new();
string Alert = "";


while (input != "") {
    Console.Clear();
    if (CurrentCharacter != null) {
        Console.WriteLine("Current Character : " + CurrentCharacter.Name);
    } else {
        Console.WriteLine("Welcome to the character building program. This is to allow you to build your character and get your stats without the need for Riley or Tree to help you.");
        Console.WriteLine("No character currently selected.");
    }
    Console.WriteLine("\nPlease select an option using the number pad and hit enter to proceed. Or don't type anything and hit enter to exit.\n1. Select character.\n2. New character");
    if(CurrentCharacter != null) {
        if(CurrentCharacter.CharRace.Picks.Count > 0) {
            Alert = "!!!!!";
        } else { Alert = ""; }
        Console.WriteLine("3. Edit character stats. " + Alert);
        Console.WriteLine("4. Edit character race.\n5. Edit character class.\n6. Change Character Name\n7. See Character Information");
    }
        input = Console.ReadLine();
    try {
        option = Int32.Parse(input);
    } catch {
        option = 0;
    }
        
    switch (option) {
        case 1:
            CurrentCharacter = running.SetCharacter();
            break;

        case 2:
            CurrentCharacter = running.NewCharacter();
            break;

        case 3:
            running.EditStats(CurrentCharacter);
            break;

        case 4:
            running.EditRace(CurrentCharacter);
            break;

        case 5:
            running.EditClass(CurrentCharacter);
            break;

        case 6:
            running.EditName(CurrentCharacter);
            break;

        case 7:
            running.DisplayCharacter(CurrentCharacter);
            break;


        default:
            break;
    }   

}
running.SaveCharacters();