using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class AddProfileSteps
    {
        [Given(@"User name and password and user is logged In")]
        public void GivenUserNameAndPasswordAndUserIsLoggedIn()
        {
            //Setup Method willbe executed 
        }
        
        [Given(@"Navigate to the profile page")]
        public void GivenNavigateToTheProfilePage()
        {
            
            Profile.NavigatetoProfilePage();
        }
        
        [Given(@"Add profile details")]
        public void GivenAddProfileDetails()
        {
            Profile.AddNewLanguage();
        }
        
        [When(@"save the profile details")]
        public void WhenSaveTheProfileDetails()
        {
            
        }
        
        [Then(@"Verify if the details are as expected")]
        public void ThenVerifyIfTheDetailsAreAsExpected()
        {
            Profile.VerifyAddedLanguage();


        }
    }
}
