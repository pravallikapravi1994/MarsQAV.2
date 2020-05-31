using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Gherkin.Ast;
using Gherkin.Events.Args.Ast;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class _1ServicelistingSteps
    {
        [Given(@"User clicks on share skill and is in Service Listing page")]
        public void GivenUserClicksOnShareSkillAndIsInServiceListingPage()
        {


          
            Driver.TurnOnWait();
            Profile.NavigatetoServiceListingPage();
        }
        
        [Given(@"Entered all the required fields in service listing page")]
        public void GivenEnteredAllTheRequiredFieldsInServiceListingPage()
        {
            ServiceListing.SaveServiceListing();
        }
        
        [When(@"User press Save button")]
        public void WhenUserPressSaveButton()
        {
            
        }
        
        [Then(@"Skill should be saved and listed in Manage listing page")]
        public void ThenSkillShouldBeSavedAndListedInManageListingPage()
        {
            ManageListing.VerifySavedSeriveList();
        }




  
    }
}
