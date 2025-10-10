Feature: StatTesting

A short summary of the feature

@Stats
Scenario: Initial Set Up
	Given The character has a 18 in Strength
	When Strength is checked
	Then The Strength bonus should be 4

	Scenario:testing1
	Given The character has a 14 in Strength
	When Strength is checked
	Then The Strength bonus should be 2

	Scenario: testing2
	Given The character has a 4 in Strength
	When Strength is checked
	Then The Strength bonus should be -3

	Scenario: testing3
	Given The character has a 4 in Strength
	And a 19 in Intelligence
	When Strength is checked
	Then The Strength bonus should be -3


	Scenario: testing4
	Given The character has a 4 in Strength
	And a 19 in Intelligence
	When Strength is checked
	Then The Strength bonus should be -3
	When Intelligence is checked
	Then The Intelligence bonus should be 4

	Scenario: testing some stats
	Given The character has a 4 in Strength
	And a 13 in Constitution
	And a 14 in Dexterity
	And a 17 in Wisdom
	And a 6 in Charisma
	When Charisma is checked
	Then The Charisma bonus should be -2
	When Wisdom is checked
	Then The Wisdom bonus should be 3
	When Dexterity is checked
	Then The Dexterity bonus should be 2
	When Constitution is checked
	Then The Constitution bonus should be 1

	Scenario: testing all stats
	Given The character has a 4 in Strength
	And a 19 in Intelligence
	And a 13 in Constitution
	And a 14 in Dexterity
	And a 17 in Wisdom
	And a 6 in Charisma
	When Strength is checked
	Then The Strength bonus should be -3
	When Intelligence is checked
	Then The Intelligence bonus should be 4
	When Charisma is checked
	Then The Charisma bonus should be -2
	When Wisdom is checked
	Then The Wisdom bonus should be 3
	When Dexterity is checked
	Then The Dexterity bonus should be 2
	When Constitution is checked
	Then The Constitution bonus should be 1

	Scenario: testing any stat
	Given The character has a 4 in Strength
	And a 19 in Intelligence
	And a 13 in Constitution
	And a 14 in Dexterity
	And a 17 in Wisdom
	And a 6 in Charisma
	When Strength is checked
	When Intelligence is checked
	When Charisma is checked
	When Wisdom is checked
	When Dexterity is checked
	When Constitution is checked
	Then The Strength bonus should be -3
	Then The Wisdom bonus should be 3
	Then The Constitution bonus should be 1
	Then The Intelligence bonus should be 4
	Then The Dexterity bonus should be 2
	Then The Charisma bonus should be -2

	Scenario: Assigning a character stats
	Given A new character is made
	When The character's name is Brant
	When Brant puts a 16 in Wisdom
	And Brant puts a 13 in Intelligence
	And Brant puts a 12 in Charisma
	And Brant puts a 14 in Dexterity
	And Brant puts a 18 in Strength
	And Brant puts a 16 in Constitution
	Then Brant has a 16 in Constitution
	Then Brant has a 16 in Wisdom
	Then Brant has a 13 in Intelligence
	Then Brant has a 12 in Charisma
	Then Brant has a 14 in Dexterity
	Then Brant has a 18 in Strength
	Then Brant has a 16 in Constitution

	Scenario: Testing Mana
		Given A new character is made
		When The character's name is Aralen
		When Aralen's class is Cleric
		And Aralen puts a 16 in Intelligence
		And Aralen puts a 18 in Wisdom
		Then Aralen's Mana total should be 38

	Scenario: Testing Health
		Given A new character is made
		When The character's name is Roric
		When Roric's class is Knight
		And Roric puts a 16 in Constitution
		And Roric puts a 18 in Strength
		And Roric puts a 12 in Wisdom
		And Roric puts a 17 in Intelligence
		And Roric puts a 13 in Dexterity
		And Roric puts a 10 in Charisma
		Then Roric's Mana total should be 36
		Then Roric's Health total should be 45

		Scenario: Testing Health with race
		Given A new character is made
		When The character's name is Roric
		When Roric's class is Knight
		And Roric puts a 16 in Constitution
		And Roric puts a 18 in Strength
		And Roric puts a 12 in Wisdom
		And Roric puts a 17 in Intelligence
		And Roric puts a 13 in Dexterity
		And Roric puts a 10 in Charisma
		Then Roric's Mana total should be 36
		Then Roric's Health total should be 45
		When Roric's race is Ulfgar
		Then Roric's Mana total should be 23
		Then Roric's Health total should be 50
