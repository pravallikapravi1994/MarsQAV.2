Feature: 1AddProfile
	
@mytag
@positivescenario
Scenario: 1 Add Language in Profile 
Given User name and password and user is logged In
	And  Navigate to the profile page 
	And  Add profile details
	When save the profile details
	Then Verify if the details are as expected 

