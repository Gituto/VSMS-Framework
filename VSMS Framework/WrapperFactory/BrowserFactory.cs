using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace VSMS_Framework.WrapperFactory
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;
        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
                private set
            {
                driver = value;
            }            
        }
        public static void InitBrowser(string browserName)
        {
            switch(browserName)
            {
                case "Chrome":
                    if(driver == null)
                    {
                        driver = new ChromeDriver();
                        Drivers.Add("Chrome", Driver);
                    }
                    break;
            }
        }
        public static void LoadApplication(string url)
        {
            Driver.Url = url;
        }
        public static void CloseAllDrivers()
        {
            foreach(var key in Drivers.Keys)
            {
                driver.Close();
                driver.Quit();                
            }
        }
    }
}
