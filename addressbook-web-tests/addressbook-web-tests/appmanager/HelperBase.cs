using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;            
        }
        public void Type(By locator, string text)
        {
            driver.FindElement(locator).Click();
            if (text != null)
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
        }
        public void Select(string fieldName, string fieldValue)
        {
            driver.FindElement(By.Name(fieldName)).Click();
            new SelectElement(driver.FindElement(By.Name(fieldName))).SelectByText(fieldValue);
            driver.FindElement(By.Name(fieldName)).Click();           
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        public string CloseAlertAndGetItsText(bool acceptNextAlert)
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}