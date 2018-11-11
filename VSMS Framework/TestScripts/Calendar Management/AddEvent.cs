using NUnit.Framework;
using System;
using System.Configuration;
using System.Threading;
using VSMS_Framework.PageObjects;
using VSMS_Framework.WrapperFactory;

namespace VSMS_Framework.TestScripts
{
    class AddEvent
    {
        
        [Test]
        public void NavigationToCalendarPage()
        {

            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);

            Pages.Home.ToLoginPage();
            Console.WriteLine("Navigated to the Login Page");

            Pages.Login.LoginToVsms("LogInTest");
            Console.WriteLine("Navigated to the system");

            Thread.Sleep(5000);

            Pages.DashBoard.NavigateToCalendarPage();
            Console.WriteLine("Navigated to the Calendar Management Page");

            Thread.Sleep(5000);
           
            Pages.Calendar.NavigateToAddEvent();
            Console.WriteLine("An event is Added and Success Msg Displayed");

        }
    }
}
