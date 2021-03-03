using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactHelper  : HelperBase

    {
        public ContactHelper(ApplicationManager manager, bool acceptNextAlert) : base(manager)
        {

        }

        public ContactHelper Remove(int index, bool alert)
        {            
            SelectContact(index);
            DeleteContact(alert);                       
            return this;
        }        

        public ContactHelper Create(ContactData contact)
        {
            InitContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            ReturneToContactsPage();
            return this;
        }
        public ContactHelper Modify(ContactData newData)
        {            
            InitContactModification();
            FillContactForm(newData);
            SubmitContactModification();
            ReturneToContactsPage();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
            return this;
        }

        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();           
            return this;
        }

        public ContactHelper ReturneToContactsPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }        

        public ContactHelper FillContactForm(ContactData contact)
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
            return this;
        }

        public ContactHelper SelectFieldValue(string fieldName, string fieldValue)
        {
            driver.FindElement(By.Name(fieldName)).Click();
            new SelectElement(driver.FindElement(By.Name(fieldName))).SelectByText(fieldValue);
            driver.FindElement(By.Name(fieldName)).Click();
            return this;
        }

        public ContactHelper FillField(string fieldName, string fieldValue)
        {
            driver.FindElement(By.Name(fieldName)).Click();
            driver.FindElement(By.Name(fieldName)).Clear();
            driver.FindElement(By.Name(fieldName)).SendKeys(fieldValue);
            return this;
        }

        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
        public ContactHelper DeleteContact(bool alert)
        {            
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(alert), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }       
    }
}
