using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
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

            List<ContactData> oldContacts = app.Contacts.GetContactList();
            app.Contacts.Create(contact);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
            //Assert.AreEqual(newContacts.Count, oldContacts.Count + 1);
        }

    }
}

