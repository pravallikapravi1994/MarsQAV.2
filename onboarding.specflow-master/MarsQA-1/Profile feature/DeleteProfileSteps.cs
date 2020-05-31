using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class DeleteProfileSteps
    {
        [Given(@"Username and password and user is logged in successfully")]
        public void GivenUsernameAndPasswordAndUserIsLoggedInSuccessfully()

        {

            Driver.TurnOnWait();
            Profile.NavigatetoProfilePage();

            
        }
        
        [Given(@"user has language added to the profile")]
        public void GivenUserHasLanguageAddedToTheProfile()
        {
            
        }
        
        [When(@"user deletes the added language")]
        public void WhenUserDeletesTheAddedLanguage()
        {
            Driver.TurnOnWait();
            Profile.DeleteLanguage();
        }

        [Then(@"verify if the language is deleted")]
        public void ThenVerifyIfTheLanguageIsDeleted()
        {

            Driver.TurnOnWait();
            Profile.VerifyDeleteLanguage();


        }
    }
}
