using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RelevantCodes.ExtentReports;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using TechTalk.SpecFlow;

using Gherkin.Ast;

namespace MarsQA_1.Helpers
{
    public class CommonMethods
    {
        //Screenshots
        //Screenshot

        public class SaveScreenShotClass
        {
            
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }

        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports Extent;
        public static ExtentHtmlReporter htmlReporter;




        public static void ExtentReports()
        {





            htmlReporter = new ExtentHtmlReporter(@"C:\Users\shankar kiran\Downloads\TestMVP\onboarding.specflow-master\MarsQA-1\TestReports\extent.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            Extent = new ExtentReports();
            Extent.AttachReporter(htmlReporter);

          




            


         











            // Extent = new ExtentReports(ConstantHelpers.ReportsPath, true, DisplayOrder.NewestFirst);
            // Extent.LoadConfig(ConstantHelpers.ReportXMLPath);
        }
    }
    #endregion

}


