using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VSMS_Framework.PageObjects;

namespace VSMS_Framework.TestScripts
{
   class AddEvent
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void NavigationToCalendarPage()
        {

            driver.Url = ConfigurationManager.AppSettings["URL"];

            var homepage = new HomePage(driver);
            homepage.ToLoginPage();
            Console.WriteLine("Navigated to the Login Page");

            var loginpage = new LoginPage(driver);
            loginpage.LoginToVsms();
            Console.WriteLine("Navigated to the system");

            Thread.Sleep(5000);

            var dashBoardObjects = new DashBoardObjects(driver);
            Console.WriteLine("Clicks the Module Tab");

            Thread.Sleep(5000);
            dashBoardObjects.NavigateToCalendarPage();
            Console.WriteLine("Navigated to the Calendar Management Page");

            Thread.Sleep(5000);
            var calendarManagementPage = new CalendarManagementPage(driver);
            calendarManagementPage.NavigateToAddEvent();
            Console.WriteLine("An event is Added and Success Msg Displayed");

            driver.Close();
        }
    }
}
