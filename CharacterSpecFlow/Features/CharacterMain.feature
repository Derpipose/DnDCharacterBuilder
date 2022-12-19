Feature: CharacterCreation

A short summary of the feature

@MainCharacter
Scenario: Setting Character Name
	Given A new character is made
	When The character's name is Paul
	Then Paul's name should be Paul

	Scenario: Setting 2 Character Names
	Given A new character is made
	When The character's name is Paul
	Then Paul's name should be Paul
	Given A new character is made
	When The character's name is Josh
	Then Josh's name should be Josh
	Given A new character is made
	When The character's name is Paul
	Given A new character is made
	When The character's name is Josh
	Then Paul's name should be Paul
	Then Josh's name should be Josh

	Scenario: Setting chracter
	Given A new character is made
	When The character's name is Jim
	And Jim's race is High Elf
	And Jim's class is Acrobat
	Then Jim's race should be High Elf
	Then Jim's class should be Acrobat
	Then Jim's name should be Jim

	Scenario: Setting 2 chracter
	Given A new character is made
	When The character's name is Jim
	Given A new character is made
	When The character's name is Paul	
	And Jim's race is High Elf
	And Jim's class is Acrobat
	And Paul's race is Kay'asa
	And Paul's class is Warden
	Then Paul's race should be Kay'asa
	Then Paul's class should be Warden
	Then Paul's name should be Paul
	Then Jim's race should be High Elf
	Then Jim's class should be Acrobat
	Then Jim's name should be Jim

	Scenario: Renaming
	Given A new character is made
	When The character's name is Jeffry
	And Jeffry's race is Half Orc
	And Jeffry's class is Monk
	Then Jeffry's name should be Jeffry
	When Jeffry is renamed to Paul
	Then Paul's name should be Paul
	Then Paul's class should be Monk
	Then Paul's race should be Half Orc

	Scenario: Building A Character
	Given A new character is made
	When The character's name is 