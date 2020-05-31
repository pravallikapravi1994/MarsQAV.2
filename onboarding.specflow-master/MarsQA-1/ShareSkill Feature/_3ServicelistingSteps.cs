using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class _3ServicelistingSteps
    {
        [Given(@"Clicks on Delete icon and edits data")]
        public void GivenClicksOnDeleteIconAndEditsData()
        {
            ManageListing.DeleteServiceList();
        }
        
        [When(@"User clicks on Ok button")]
        public void WhenUserClicksOnOkButton()
        {
            ManageListing.DeleteYes();
          
        }
        
        [Then(@"Skill should be deleted")]
        public void ThenSkillShouldBeDeleted()
        {
            ManageListing.VerifyDeletedService();
        }



        [When(@"User clicks on cancel button")]
        public void WhenUserClicksOnCancelButton()
        {
            ManageListing.DeleteNo();
        }


        [Then(@"Skill should not be deleted")]
        public void ThenSkillShouldNotBeDeleted()
        {
            ManageListing.VerifyServicenNotDeleted();
        }


    }
}
