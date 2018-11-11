using NUnit.Framework;
using VSMS_Framework.PageObjects;
using System;
using System.Configuration;
using VSMS_Framework.WrapperFactory;

namespace VSMS_Framework.TestScripts
{

    class Login
    {
                
        [Test]
        public void ValidLogin()
        {

            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);            
           
            Pages.Home.ToLoginPage();            
            Console.WriteLine("Navigated to the Login Page");

            Pages.Login.LoginToVsms("LogInTest");
            Console.WriteLine("Navigated to the system");        

           
        }

       [Test]
        public void InvalidLogin()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);

            Pages.Home.ToLoginPage();
            Console.WriteLine("Navigated to the Login Page");

            Pages.Login.InvalidLoginToVsms("InvalidLogInTest");
            Console.WriteLine("Displays Error Message");

            
        }

    }
}
