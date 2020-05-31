using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Gherkin.Ast;
using Gherkin.Events.Args.Ast;
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
//using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {
        public object LogStatus { get; private set; }

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            
            Initialize();
            Driver.TurnOnWait();
          ExcelLibHelper.PopulateInCollection(@"C:\Users\shankar kiran\Downloads\TestMVP\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\ServiceListData.xlsx", "Service Data");
            //call the SignIn class
            SignIn.SigninStep();
            Driver.TurnOnWait();

            CommonMethods.ExtentReports();



        }

        [AfterScenario]
        public void TearDown()
        {


            

            CommonMethods.Extent.Flush();
            //driver.Close();



            Driver.driver.Close();

            //Driver.TurnOnWait();
            // Screenshot
           //string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Screenshots");



            
            
         //  test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            //Close();






            //end test. (Reports)
           



            //Driver.driver.Quit();

            // calling Flush writes everything to the log file (Reports)


            //CommonMethods.Extent.Flush();



            
           

        }
    }
}
