Feature: ProfileDelete


@mytag
@postiviescenario
Scenario: Delete added language in profile page 
	Given User is logged in and is in profile page
	And User has languge added to the profile
	When  User clicks on Delete icon of a language
	Then particular language should be removed from the user profile


@positive scenario
Scenario: Delete added Skill in profile page 
	Given User is logged in and is in profile page
	And User has Skill added to the profile
	When  User clicks on Delete icon of a Skill
	Then particular skill should be removed from the user profile


@positive scenario
Scenario: Delete added Education in profile page 
	Given User is logged in and is in profile page
	And User has Education added to the profile
	When  User clicks on Delete icon of a Education 
	Then particular education details should be removed from the user profile

@positive scenario
Scenario: Delete added Certification in profile page 
	Given User is logged in and is in profile page
	And User has certification added to the profile
	When  User clicks on Delete icon of a Certificate 
	Then particular certification details should be removed from the user profile


