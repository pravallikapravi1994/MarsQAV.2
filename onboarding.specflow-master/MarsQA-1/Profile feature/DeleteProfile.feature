Feature: 3DeleteProfile
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: 3 Delete profile functionality(Delete Language)
	Given Username and password and user is logged in successfully
	And user has language added to the profile 
	When user deletes the added language
	Then verify if the language is deleted