Feature: RaceTesting

A short summary of the feature

@tag1
Scenario: Setting up race features
	Given A new character is made
	When The character's name is Brant
	And Brant's race is Ulfgar
	Then Brant's Intelligence score should be -2
	Then Brant's Strength score should be 2
	Then Brant's Constitution score should be 2

Scenario: Creating Stats with a race
	Given A new character is made
	When The character's name is Maeve
	And Maeve's race is Strathund
	When Maeve puts a 16 in Wisdom
	And Maeve puts a 13 in Intelligence
	And Maeve puts a 12 in Charisma
	And Maeve puts a 14 in Dexterity
	And Maeve puts a 18 in Strength
	And Maeve puts a 16 in Constitution
	Then Maeve has a 16 in Constitution
	Then Maeve has a 16 in Wisdom
	Then Maeve has a 14 in Intelligence
	Then Maeve has a 12 in Charisma
	Then Maeve has a 16 in Dexterity
	Then Maeve has a 18 in Strength
	Then Maeve has a 16 in Constitution
