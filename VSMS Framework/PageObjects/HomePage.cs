using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace VSMS_Framework.PageObjects
{
   public  class HomePage
    {
        private IWebDriver driver;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//a[@id='login']")]
        public IWebElement LoginLink{get;set;}

        [CacheLookup]
        [FindsBy(How=How.XPath, Using = "//a[@id='contact-us']")]
        public IWebElement ContactUsLink { get; set; }

        [CacheLookup]
        [FindsBy(How=How.XPath, Using = "//a[@id='plans']")]
        public IWebElement PlansLink { get; set; }

        [CacheLookup]
        [FindsBy(How=How.XPath, Using = "//a[@id='overview']")]
        public IWebElement OverviewLink { get; set; }
       
        public void ToLoginPage()
        {
            LoginLink.Click();
        }
    }
    
}
