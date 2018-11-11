using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace VSMS_Framework.PageObjects
{
    public class DashBoardObjects
    {
        private IWebDriver driver;

        [CacheLookup]
        [FindsBy(How=How.XPath, Using ="//a[contains(.,'  Modules')]")]
        public IWebElement ModulesLink { get; set; }

        [CacheLookup]
        [FindsBy(How =How.XPath, Using = "//a[contains(.,' Calendar Management')]")]
        public IWebElement CalendarManagement { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//a[@id='Calendar ']")]
        public IWebElement CalendarLink { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//a[contains(.,' User  Management')]")]
        public IWebElement UserManagement { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//a[@id='User']")]
        public IWebElement UserLink { get; set; }


        public void NavigateToCalendarPage()
        {
            ModulesLink.Click();
            Thread.Sleep(5000);
            CalendarManagement.Click();
            CalendarLink.Click();
           
        }

    }
}
