﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]")).Click();           
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
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("mobile"), contact.Mobile);
            Type(By.Name("email"), contact.Email);
            Select("bmonth", "22");
            Select("bday", "January");
            Type(By.Name("byear"), "2000");
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
        public ContactHelper IfEmptyContact(int index)
        {
            ContactData contact = new ContactData("Peter", "Petersson")
            {
                Title = "Mr",
                Company = "Zaza",
                Mobile = "998645",
                Email = "ttt@hh.com",
                Address = "Teststreet 100, 00000, Testcity"
            };

            if (!IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + (index +1) + "]")))
            {
                Create(contact);
                return this;
            }
            return this;
        }

        public List<ContactData> GetContactList()
        {
            List<ContactData> contacts = new List<ContactData>();
            manager.Navigator.GoToHomePage();            
            ICollection<IWebElement> elements = driver.FindElements(By.XPath("//table[@id='maintable']/tbody/tr"));
            foreach (IWebElement element in elements)
            {
                string[] a = element.Text.Split(new Char[] { ' ', ',' });                
                contacts.Add(new ContactData(a[1], a[0]));                
            }
            return contacts;
        }

    }
}
