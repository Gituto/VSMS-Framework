using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace VSMS_Framework.PageObjects
{
    public class CalendarManagementPage
    {
        private IWebDriver driver;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//button[@title='Add New Event']")]
        public IWebElement AddNewEventButton { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//input[@id='title']")]
        public IWebElement Title { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//input[@id='date1']")]
        public IWebElement StartDate { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//input[@id='time1']")]
        public IWebElement StartTime { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//input[@id='date2']")]
        public IWebElement Enddate { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//input[@id='time2']")]
        public IWebElement EndTime { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//select[@id='location_data']")]
        public IWebElement LocationDropdown { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//option[@label='Balozi/Whitecap/Heinken']")]
        public IWebElement LocationOption { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//input[@id='self']")]
        public IWebElement FormeCheckBox { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//textarea[@id='event-description']")]
        public IWebElement EventDescription { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//button[@id='step11']")]
        public IWebElement SaveEvent { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using =("//div[@ng-show='successAlert']"))]
        public IWebElement SuccessMessage{get;set;}

        public void NavigateToAddEvent()
        {
            AddNewEventButton.Click();
            Title.SendKeys("Interview");
            LocationDropdown.Click();
            Thread.Sleep(5000);
            LocationOption.Click();
            EventDescription.SendKeys("Sorry for the late response, i had some emergencies");
            SaveEvent.Click();
            Thread.Sleep(5000);
            //Assert.AreEqual(true, SuccessMessage.Displayed);
            
        }

    }
}
