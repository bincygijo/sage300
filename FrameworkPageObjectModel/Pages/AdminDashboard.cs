using FrameworkPageObjectModel.Global;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static FrameworkPageObjectModel.Global.CommonMethods;

namespace FrameworkPageObjectModel.Pages
{
   public class AdminDashboard
    {
        public void ValidateAdmin()
        {
            //Populate in collection
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "admindashboard");

            //Clicking on admin button
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
            Thread.Sleep(5000);

                                   
            //Adding screenshot in extendReport
            SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "admindashboard");
            string screenShotPath = Global.CommonMethods.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "admindashboard");
            Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath));


        }
    }
}
