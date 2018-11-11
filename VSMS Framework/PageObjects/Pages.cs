using OpenQA.Selenium.Support.PageObjects;
using VSMS_Framework.WrapperFactory;

namespace VSMS_Framework.PageObjects
{
    public static class Pages
    {
        private static T GetPage<T>() where T: new()
        {
            var page = new T();
            //IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }
        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }
        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }
        public static DashBoardObjects DashBoard
        {
            get { return GetPage<DashBoardObjects>(); }
        }
        public static CalendarManagementPage Calendar
        {
            get { return GetPage<CalendarManagementPage>(); }
        }

    }
}
