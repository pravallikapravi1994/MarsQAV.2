using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class EditProfileSteps
    {
        [Given(@"Username and Password and user is able to login successfully")]
        public void GivenUsernameAndPasswordAndUserIsAbleToLoginSuccessfully()
        {
            
        }
        
        [Given(@"Navigate to profile page and Edit required language")]
        public void GivenNavigateToProfilePageAndEditRequiredLanguage()
        {
            Profile.NavigatetoProfilePage();
            Driver.TurnOnWait();
            Profile.EditLanguage();

        }
        
        [When(@"update language")]
        public void WhenUpdateLanguage()
        {
            
        }
        
        [Then(@"verify if language is edited successfully")]
        public void ThenVerifyIfLanguageIsEditedSuccessfully()
        {
            Profile.VerifyEditedLanguage();
            
        }
    }
}
