using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {     
        [Test]
        public void ContactCreationTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin","secret"));
            InitContactCreation();
            ContactData contact = new ContactData("Peter", "Petersson")
            {
                Title = "Mr",
                Company = "Zaza",
                Mobile = "998645",
                Email = "ttt@hh.com",
                Address = "Teststreet 100, 00000, Testcity"
            };
            FillContactForm(contact);
            SubmitContactCreation();
            ReturneToContactsPage();
            loginHelper.Logout();
        }       
        
    }
}

