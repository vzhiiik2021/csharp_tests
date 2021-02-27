using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        //protected ApplicationManager manager;

        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;        
        }
        //public HelperBase (ApplicationManager manager)
        //{
        //    this.manager = manager;
        //    driver = manager.Driver;
            
        //}
    }
}