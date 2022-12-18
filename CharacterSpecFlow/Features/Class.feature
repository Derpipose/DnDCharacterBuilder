Feature: ClassTesting

A short summary of the feature

@tag1
Scenario: Testing Class Features
	Given A new character is made
	When The character's name is Brant
	And Brant's class is Warden
	Then Brant's class should be Warden
	Then Brant's hit die should be 12
	Then Brant's mana die should be 6
