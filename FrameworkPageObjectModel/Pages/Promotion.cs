using FrameworkPageObjectModel.Global;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static FrameworkPageObjectModel.Global.CommonMethods;
using static NUnit.Core.NUnitFramework;

namespace FrameworkPageObjectModel.Pages
{
   public class Promotion
    {
        public void AddPublicPromo()
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

            //Populate in collection
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "promotion");

            //Clicking on Promotions link
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
            Thread.Sleep(2000);

            //Clicking on Public promo link
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));
            Thread.Sleep(2000);

            //Clicking on Create New Promo Code
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"));
            Thread.Sleep(2000);

            //Adding screenshot in extendReport
            SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Promotion");
            string screenShotPath1 = Global.CommonMethods.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Promotion");
            Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath1));

            //clear promo code
            GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"));

            //Enter promo code
            GlobalDefinitions.Textbox(GlobalDefinitions.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "LocatorValue"), ExcelLib.ReadData(6, "InputValue"));
            Thread.Sleep(2000);

            //Enter Description
            GlobalDefinitions.Textbox(GlobalDefinitions.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "LocatorValue"), ExcelLib.ReadData(7, "InputValue"));
            Thread.Sleep(2000);

            //Clicking on amount radio button
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "LocatorValue"));
            Thread.Sleep(2000);

            //clear amount 0 value
            GlobalDefinitions.GetClear(GlobalDefinitions.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "LocatorValue"));

            //Enter Discount amount
            GlobalDefinitions.Textbox(GlobalDefinitions.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "LocatorValue"), ExcelLib.ReadData(10, "InputValue"));
            Thread.Sleep(2000);

            //Clicking on Apply button
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "LocatorValue"));
            Thread.Sleep(2000);

            string ActResult = "New promotion code successfully created";
            try
            {
                Assert.AreEqual(ActResult, GlobalDefinitions.GetTextValue(GlobalDefinitions.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "LocatorValue")));
                Base.test.Log(LogStatus.Pass, "Promotion code created: Expected & Actual results are equal");

                //Adding screenshot in extendReport
                SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Promotion code created");
                string screenShotPath2 = Global.CommonMethods.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Promotion code created");
                Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath2));

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test fail");
                Base.test.Log(LogStatus.Info, e.Message + ">>No message for Invalid Promotion");
            }


        }
    }
}
