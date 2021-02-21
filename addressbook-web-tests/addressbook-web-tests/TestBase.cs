using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost";
            verificationErrors = new StringBuilder();
            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);

        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        public void ReturneToContactsPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }

        public void SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
        }

        public void FillContactForm(ContactData contact)
        {
            FillField("firstname", contact.Firstname);
            FillField("lastname", contact.Lastname);
            FillField("title", contact.Title);
            FillField("company", contact.Company);
            FillField("address", contact.Address);
            FillField("mobile", contact.Mobile);
            FillField("email", contact.Email);
            SelectFieldValue("bmonth", "22");
            SelectFieldValue("bday", "January");
            FillField("byear", "2000");
        }

        public void SelectFieldValue(string fieldName, string fieldValue)
        {
            driver.FindElement(By.Name(fieldName)).Click();
            new SelectElement(driver.FindElement(By.Name(fieldName))).SelectByText(fieldValue);
            driver.FindElement(By.Name(fieldName)).Click();
        }

        public void FillField(string fieldName, string fieldValue)
        {
            driver.FindElement(By.Name(fieldName)).Click();
            driver.FindElement(By.Name(fieldName)).Clear();
            driver.FindElement(By.Name(fieldName)).SendKeys(fieldValue);
        }

        public void InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

    }
}
