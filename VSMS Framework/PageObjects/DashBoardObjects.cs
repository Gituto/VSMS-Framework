using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace VSMS_Framework.PageObjects
{
    class DashBoardObjects
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


        public DashBoardObjects(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void NavigateToCalendarPage()
        {
            ModulesLink.Click();
           
            CalendarManagement.Click();
            CalendarLink.Click();
           
        }

    }
}
