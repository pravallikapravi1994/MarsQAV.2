Feature: ProfileAdd



@positivescenario
Scenario: Add Language in Profile New
Given User is loggedIn and is in profile page
And  User is in language tab
And  User clicks on Add new and Enters the language details 
When User clicks on Add
Then Language should be added to the profile

@positivescenario
Scenario: Add Description in profile  
Given User is loggedIn and is in profile page
And User clicks on edit decription 
And User enters description details 
When User clicks on Save button
Then Entered description should be saved successfully

@positivescenario
Scenario: Add Skills in profile 
Given User is loggedIn and is in profile page
And User navigates to Skills tab and selects Add New
And User enters skill and chooses Skill level
When User clicks on Add button
Then Skill should be added to the profile


@positivescenario
Scenario: Add Education in profile 
Given User is loggedIn and is in profile page
And User navigates to Education tab  and selects Add New
And User enters all the required education details 
When User clicks on Add button
Then Education should be added to the profile

@positivescenario
Scenario: Add certification in profile 
Given User is loggedIn and is in profile page
And User navigates to certification tab  and selects Add New
And User enters certification details and selects year
When User clicks on Add button
Then Certification should be added to the profile

@negativescenario
Scenario: Users tries to add language and cancels 
Given User is loggedIn and is in profile page
And  User is in language tab
And  User clicks on Add new and Enters the language details 
When User clicks on cancel button
Then Language should not be added to the profile

@negativescenario
Scenario: Users tries description but does not Save
Given User is loggedIn and is in profile page
And User clicks on edit decription 
And User enters description details 
And User does not click on Save button
When user refreshes the page
Then Entered description should not be saved

@negativescenario
Scenario: Users tries to add skill and cancels 
Given User is loggedIn and is in profile page
And User navigates to Skills tab and selects Add New
And User enters skill and chooses Skill level
When User clicks on Cancel button
Then Skill should not be added to the profile


@negativescenario
Scenario: Users tries to add education and cancels 
Given User is loggedIn and is in profile page
And User navigates to Education tab  and selects Add New
And User enters all the required education details 
When User clicks on cancel button
Then Education details should not be added to the profile

@negativescenario
Scenario: Users tries to add certification and cancels 
Given User is loggedIn and is in profile page
And User navigates to certification tab  and selects Add New
And User enters certification details and selects year
When User clicks on cancel button
Then Certification should not be added to the profile

