using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace VSMS_Framework.PageObjects
{
    class LoginPage
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



        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoginToVsms()
        {
            Email.SendKeys("eapungu@gmail.com");
            Password.SendKeys("Desteg@3871");
            LoginButton.Click();

        }


        public void InvalidLoginToVsms()
        {
            Email.SendKeys("eapungu@gmail.com");
            Password.SendKeys("Dest@3871");
            LoginButton.Click();
            Thread.Sleep(5000);
            Assert.AreEqual(true, LoginErrorMsg.Displayed);
        }
    }
}
