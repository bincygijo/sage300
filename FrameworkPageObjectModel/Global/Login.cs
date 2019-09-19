using FrameworkPageObjectModel.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FrameworkPageObjectModel.Global.CommonMethods;

namespace FrameworkPageObjectModel.Global
{
    class Login
    {
        public static int LoginBase = Int32.Parse(Resource.Login);

        public void LoginSuccessfull()
        {

            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Login");

            // Navigating to Login page using value from Excel
           GlobalDefinitions.driver.Navigate().GoToUrl(ExcelLib.ReadData(LoginBase, "Url"));

            // Sending the username 
            GlobalDefinitions.Textbox(GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"), ExcelLib.ReadData(LoginBase, "Email"));
            GlobalDefinitions.wait(500);

            // Sending the password
            GlobalDefinitions.Textbox(GlobalDefinitions.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"), ExcelLib.ReadData(LoginBase, "Password"));
           

            // Clicking on the login button
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"));
           


        }

    }
}
