﻿Feature: StatTesting

A short summary of the feature

@Stats
Scenario: Initial Set Up
	Given The character has an 18 in Strength
	When Strength is checked
	Then The Strength bonus should be 4

	Scenario:testing1
	Given The character has an 14 in Strength
	When Strength is checked
	Then The Strength bonus should be 2

	Scenario: testing2
	Given The character has an 4 in Strength
	When Strength is checked
	Then The Strength bonus should be -3

	Scenario: testing3
	Given The character has an 4 in Strength
	And a 19 in Intelegence
	When Strength is checked
	Then The Strength bonus should be -3


	Scenario: testing4
	Given The character has an 4 in Strength
	And a 19 in Intelegence
	When Strength is checked
	Then The Strength bonus should be -3
	When Intelegence is checked
	Then The Intelegence bonus should be 4

	Scenario: testing some stats
	Given The character has an 4 in Strength
	And a 13 in Constitution
	And a 14 in Dexterity
	And a 17 in Wisdom
	And a 6 in Charasma
	When Charasma is checked
	Then The Charasma bonus should be -2
	When Wisdom is checked
	Then The Wisdom bonus should be 3
	When Dexterity is checked
	Then The Dexterity bonus should be 2
	When Constitution is checked
	Then The Constitution bonus should be 1

	Scenario: testing all stats
	Given The character has an 4 in Strength
	And a 19 in Intelegence
	And a 13 in Constitution
	And a 14 in Dexterity
	And a 17 in Wisdom
	And a 6 in Charasma
	When Strength is checked
	Then The Strength bonus should be -3
	When Intelegence is checked
	Then The Intelegence bonus should be 4
	When Charasma is checked
	Then The Charasma bonus should be -2
	When Wisdom is checked
	Then The Wisdom bonus should be 3
	When Dexterity is checked
	Then The Dexterity bonus should be 2
	When Constitution is checked
	Then The Constitution bonus should be 1

	Scenario: testing any stat
	Given The character has an 4 in Strength
	And a 19 in Intelegence
	And a 13 in Constitution
	And a 14 in Dexterity
	And a 17 in Wisdom
	And a 6 in Charasma
	When Strength is checked
	When Intelegence is checked
	When Charasma is checked
	When Wisdom is checked
	When Dexterity is checked
	When Constitution is checked
	Then The Strength bonus should be -3
	Then The Wisdom bonus should be 3
	Then The Constitution bonus should be 1
	Then The Intelegence bonus should be 4
	Then The Dexterity bonus should be 2
	Then The Charasma bonus should be -2