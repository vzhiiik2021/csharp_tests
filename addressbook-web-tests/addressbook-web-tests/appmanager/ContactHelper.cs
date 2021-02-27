using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactHelper  : HelperBase
    {
        public ContactHelper (IWebDriver driver) : base (driver)
        {

        }
        //public ContactHelper(ApplicationManager manager) : base(manager)
        //{

        //}
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
