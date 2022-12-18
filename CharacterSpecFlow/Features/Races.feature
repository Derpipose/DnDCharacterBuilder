Feature: RaceTesting

A short summary of the feature

@tag1
Scenario: Setting up race features
	Given A new character is made
	When The character's name is Brant
	And Brant's race is Ulfgar
	Then Brant's Intelegence score should be -2
	Then Brant's Strength score should be 2
	Then Brant's Constitution score should be 2

Scenario: Creating Stats with a race
	Given A new character is made
	When The character's name is Maeve
	And Maeve's race is Strathund
	When Maeve has a 16 in Wisdom
	And Maeve has a 13 in Intelegence
	And Maeve has a 12 in Charasma
	And Maeve has a 14 in Dexterity
	And Maeve has a 18 in Strength
	And Maeve has a 16 in Constitution
	Then Maeve has a 16 in Constitution
	Then Maeve has a 16 in Wisdom
	Then Maeve has a 14 in Intelegence
	Then Maeve has a 12 in Charasma
	Then Maeve has a 16 in Dexterity
	Then Maeve has a 18 in Strength
	Then Maeve has a 16 in Constitution
