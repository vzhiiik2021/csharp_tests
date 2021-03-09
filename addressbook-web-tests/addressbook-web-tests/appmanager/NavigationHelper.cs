using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {       
        readonly string baseURL;        
               
        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        public NavigationHelper GoToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return this;
            }
          driver.Navigate().GoToUrl(baseURL + "/addressbook/");
          return this;
        }
        public NavigationHelper GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
               && IsElementPresent(By.Name("new")))
            {
                return this;
            }
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }
    }
}
