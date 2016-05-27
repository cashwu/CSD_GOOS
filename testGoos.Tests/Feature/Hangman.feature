Feature: Hangman
	
Scenario: Hangman Game
	Given have a work "cash"
	When game start
	Then tries have show 12
	And  length have show 4
	And  used have show "AEIOU"
	And  discovered have show "_a__"
