Feature: 1Servicelisting
	
@mytag
Scenario: 1ShareSkill-Add and Save skill
	Given User clicks on share skill and is in Service Listing page
	And Entered all the required fields in service listing page
	When User press Save button
	Then Skill should be saved and listed in Manage listing page


Scenario: 2Edit shared skill
	Given User clicks on Manage listing page and navigates to Manage listing page
	And Click on Edit icon and edits data
	When Press save button
	Then Skill should be updated and in Manage listing page


Scenario: 4Delete shared skill
	Given User clicks on Manage listing page and navigates to Manage listing page
	And Clicks on Delete icon and edits data
	When User clicks on Ok button
	Then Skill should be deleted


	Scenario: 3 Try to Delete shared skill and Cancel
	Given User clicks on Manage listing page and navigates to Manage listing page
	And Clicks on Delete icon and edits data
	When User clicks on cancel button
	Then Skill should not be deleted