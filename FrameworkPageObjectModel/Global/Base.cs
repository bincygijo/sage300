using FrameworkPageObjectModel.Config;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkPageObjectModel.Global
{
   public abstract class Base
    {
        #region To access Path from resource file
        public static int Browser = Int32.Parse(Resource.Browser);
        public static String ExcelPath = Resource.ExcelPath;
        public static string ScreenshotPath = Resource.ScreenshotPath;
        public static string ReportPath = Resource.ReportPath;
        #endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        #endregion


        #region Setup
        [SetUp]
        public void Inititalise()
        {


            switch (Browser)
            {
                case 1:
                    GlobalDefinitions.driver = new FirefoxDriver();
                    break;
                case 2:
                    var options = new ChromeOptions();
                    options.AddArguments("chrome.switches", "--disable-extensions  --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
                    options.AddUserProfilePreference("credentials_enable_service", false);
                    options.AddUserProfilePreference("profile.password_manager_enabled", false);
                    GlobalDefinitions.driver = new ChromeDriver(options);
                    break;
            }

            if (Resource.IsLogin == "true")
           {
               Login loginobj = new Login();
               loginobj.LoginSuccessfull();
          }
          else
         {
                // Register obj = new Register();
                // obj.Navigateregister();
                Console.WriteLine("Loginfailed");
          }



            extent = new ExtentReports(ReportPath, false, DisplayOrder.OldestFirst);
            extent.LoadConfig(Resource.ReportXMLPath);
           // extent.LoadConfig(@"C:\Users\bincy\OneDrive\Desktop\PHO\Testing\Tutorial-POM\FrameworkPageObjectModel\FrameworkPageObjectModel\Config\Report.xml");
        }


        #endregion

        #region TearDown
        [TearDown]
        public void TearDown()
        {
            // step log
           // test.Log(LogStatus.Pass, "Step details");
            // ending test
         //   extent.EndTest(test);

            // writing everything to document
            extent.Flush();
           
            // Close the driver :           
            GlobalDefinitions.driver.Close();
        }
        #endregion
    }
}
