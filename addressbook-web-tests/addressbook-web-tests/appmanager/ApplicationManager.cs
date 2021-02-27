using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;       
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        public ApplicationManager ()
        {
            driver = new ChromeDriver();        
            baseURL = "http://localhost";

            //Navigator = new NavigationHelper(this, baseURL);
            Navigator = new NavigationHelper(driver, baseURL);
            loginHelper = new LoginHelper(driver);
                        
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver); 
        }
        public IWebDriver Driver { get; }
        public LoginHelper Auth { get; }
        public NavigationHelper Navigator { get; }
        public GroupHelper Groups { get; }
        public ContactHelper Contacts { get; }
        

        public void Stop ()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
