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
            ContactData contact = new ContactData("Peter", "Petersson")
            {
                Title = "Mr",
                Company = "Zaza",
                Mobile = "998645",
                Email = "ttt@hh.com",
                Address = "Teststreet 100, 00000, Testcity"
            };
            
            app.Contacts.Create(contact);                       
        }     
        
    }
}

