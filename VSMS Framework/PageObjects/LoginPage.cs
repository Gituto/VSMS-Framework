using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using VSMS_Framework.Test_Data.User_Login;

namespace VSMS_Framework.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        [CacheLookup]
        [FindsBy(How=How.XPath, Using = "//input[@id='email']")]
        public IWebElement Email { get; set; }

        [CacheLookup]
        [FindsBy(How=How.XPath, Using= "//input[@id='password']")]
        public IWebElement Password { get; set; }

        [CacheLookup]
        [FindsBy(How =How.XPath,Using = "//input[@name='remember']")]
        public IWebElement Rememberme { get; set; }

        [CacheLookup]
        [FindsBy(How=How.XPath, Using= "//button[@id='login-btn']")]
        public IWebElement LoginButton { get; set; }

        [CacheLookup]
        [FindsBy(How=How.XPath, Using =("//strong[contains(.,'These credentials do not match our records.')]"))]
        public IWebElement LoginErrorMsg { get; set; }


        public void LoginToVsms(string testName)
        {
            var userLoginData = UserLoginDataAccess.GetLoginTestData(testName);

            Email.SendKeys(userLoginData.Username);
            Password.SendKeys(userLoginData.Password);
            LoginButton.Click();

        }


       public void InvalidLoginToVsms(string testName)
        {
            var invalidUserLoginData = UserLoginDataAccess.GetLoginTestData(testName);
            Email.SendKeys(invalidUserLoginData.Username);
            Password.SendKeys(invalidUserLoginData.Password);            
            LoginButton.Click();
            Thread.Sleep(5000);
            Assert.AreEqual(true, LoginErrorMsg.Displayed);
        }
    }
}
