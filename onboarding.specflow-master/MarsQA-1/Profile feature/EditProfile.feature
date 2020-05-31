Feature: 2EditProfile
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: 2 Edit profile functionality(Edit Language)
	Given  Username and Password and user is able to login successfully 
	And  Navigate to profile page and Edit required language 
	When update language
	Then verify if language is edited successfully 
