using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using VSMS_Framework.PageObjects;
using System;
using System.Configuration;

namespace VSMS_Framework.TestScripts
{

    class Login
    {
                
        [Test]
        public void ValidLogin()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var homepage = new HomePage(driver);
            homepage.ToLoginPage();
            Console.WriteLine("Navigated to the Login Page");

            var loginpage = new LoginPage(driver);
            loginpage.LoginToVsms();
            Console.WriteLine("Navigated to the system");
            driver.Close();         
        }

        [Test]
        public void InvalidLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["URL"];
            var homepage = new HomePage(driver);
            homepage.ToLoginPage();
            Console.WriteLine("Navigated to the Login Page");

            var loginpage = new LoginPage(driver);
            loginpage.InvalidLoginToVsms();
            Console.WriteLine("Displays Error Message");
            driver.Close();
        }

    }
}
