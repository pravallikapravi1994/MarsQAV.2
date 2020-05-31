Feature: ProfileEdit
	

@positivescenarios
Scenario: Edit added language in Profile
	Given User is LoggedIn and is in Profile page
	And User is in Language tab and User has languages added 
	And User clicks on Edit icon and Edits selected language
	When User clicks on update button in language tab
	Then edited language should be updated in the profile page

@positivescenarios
Scenario: Edit added Skill in Profile
	Given User is LoggedIn and is in Profile page
	And User is in Skill tab and User has Skills added 
	And User clicks on Edit icon and Edits selected skill details
	When User clicks on update button in skill tab
	Then edited skill should be updated in the profile page


@positivescenarios
Scenario: Edit added Education in Profile
	Given User is LoggedIn and is in Profile page
	And User is in Education tab and User has Education added 
	And User clicks on Edit icon and Edits selected Education details
	When User clicks on update button in Education tab
	Then edited education details should be updated in the profile page


@positivescenarios
Scenario: Edit added certification in Profile
	Given User is LoggedIn and is in Profile page
	And User is in certificate tab and User has certifications added 
	And User clicks on Edit icon and Edits selected certificate details
	When User clicks on update button in certificate tab
	Then edited certificate details should be updated in the profile page

@positivescenarios
Scenario: Edit FirstName and LastName in Profile
	Given User is LoggedIn and is in Profile page
	And User clicks on Name expand icon 
	And User edits FirstName and LastName
	When User clicks on Save button in Name expand button
	Then edited FirstName and LastName should be updated in the profile page

@positivescenarios
Scenario: Edit Availability in Profile 
	Given User is LoggedIn and is in Profile page
	And User clicks on Edit Availability dropdown icon 	 
	When User selects any drop down value for Availability
	Then Availability should be updated in the profile page

@positivescenarios
Scenario: Edit Hours in Profile 
	Given User is LoggedIn and is in Profile page
	And User clicks on Edit Hours dropdown icon 	 
	When User selects any drop down value for Hours
	Then Hours should be updated in the profile page


	
@positivescenarios
Scenario: Edit EarnTarget in Profile 
	Given User is LoggedIn and is in Profile page
	And User clicks on Earn targert Edit dropdown icon 	 
	When User selects any drop down value for EarnTarget
	Then Earntarget value should be updated in the profile page



	@negativescenarios
Scenario:  User tries to Edit added language and cancels in Profile
	Given User is LoggedIn and is in Profile page
	And User is in Language tab and User has languages added 
	And User clicks on Edit icon and Edits selected language
	When User clicks on cancel button in language tab
	Then  language should not be edited in the profile page

@negativescenarios
Scenario: user tries to Edit added Skill  and cancels in Profile
	Given User is LoggedIn and is in Profile page
	And User is in Skill tab and User has Skills added 
	And User clicks on Edit icon and Edits selected skill details
	When User clicks on cancel button in skill tab
	Then Edited skill should not be updated in the profile page


@negativescenarios
Scenario: User tries to Edit added Education and cancels in Profile
	Given User is LoggedIn and is in Profile page
	And User is in Education tab and User has Education added 
	And User clicks on Edit icon and Edits selected Education details
	When User clicks on cancel button in Education tab
	Then edited education details should not be updated in the profile page


@negativescenarios
Scenario: Uer tries to Edit added certification and cancels 
	Given User is LoggedIn and is in Profile page
	And User is in certificate tab and User has certifications added 
	And User clicks on Edit icon and Edits selected certificate details
	When User clicks on update button in certificate tab
	Then edited certificate details should be updated in the profile page

@negativescenarios
Scenario: User tries to Edit FirstName and LastName and does not save
	Given User is LoggedIn and is in Profile page
	And User clicks on Name expand icon 
	And User edits FirstName and LastName and does not click on save button
	When User refreshes the profile page
	Then edited FirstName and LastName should not be updated in the profile page



@negativescenarios
Scenario: User tries to Edit Availability and cancels 
	Given User is LoggedIn and is in Profile page
	And User clicks on Edit Availability dropdown icon 	 
	When User clicks on close icon for Availability
	Then Availability drop down should be closed 

@positivescenarios
Scenario: User tries Edit Hours and cancels in Profile 
	Given User is LoggedIn and is in Profile page
	And User clicks on Edit Hours dropdown icon 	 
	When User clicks on close icon for Hours
	Then Hours drop down should be closed 


	
@positivescenarios
Scenario: User tries to Edit EarnTarget and cancels in Profile 
	Given User is LoggedIn and is in Profile page
	And User clicks on Earn target Edit dropdown icon 	 
	When User clicks on close button for Earntarget
	Then Earntarget drop down should be closed




	






