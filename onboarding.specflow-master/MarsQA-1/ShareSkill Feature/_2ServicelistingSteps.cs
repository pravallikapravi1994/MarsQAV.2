using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class _2ServicelistingSteps
    {
        [Given(@"User clicks on Manage listing page and navigates to Manage listing page")]
        public void GivenUserClicksOnManageListingPageAndNavigatesToManageListingPage()
        {

            

            ManageListing.NavigatetoManagelisting();
        }
        
        [Given(@"Click on Edit icon and edits data")]
        public void GivenClickOnEditIconAndEditsData()
        {
            ManageListing.EditSeriveList();

        }
        
        [When(@"Press save button")]
        public void WhenPressSaveButton()
        {
            
        }
        
        [Then(@"Skill should be updated and in Manage listing page")]
        public void ThenSkillShouldBeUpdatedAndInManageListingPage()
        {
            ManageListing.VerifySavedSeriveList();
        }
    }
}
