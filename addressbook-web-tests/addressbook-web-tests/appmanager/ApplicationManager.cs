using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;       
        protected string baseURL;
        protected bool acceptNextAlert;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager ()
        {
            driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);           

            baseURL = "http://localhost";
            acceptNextAlert = true;
                        
            navigator = new NavigationHelper(this, baseURL);
            loginHelper = new LoginHelper(this);
                        
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this, acceptNextAlert); 
        }
        ~ApplicationManager()
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

        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstance= new ApplicationManager();
                newInstance.Navigator.GoToHomePage();
                app.Value = newInstance;
               
            }
            return app.Value;
        }
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }       
        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }
        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }
        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }
        public ContactHelper Contacts
        {
            get
            {
                return contactHelper;
            }
        }      
    }
}
