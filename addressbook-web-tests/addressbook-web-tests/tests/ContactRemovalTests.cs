using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {     
        [Test]
        public void ContactRemovalTest()
        {

            app.Contacts.IfEmptyContact(1);
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Remove(0, true);
            List<ContactData> newContacts = app.Contacts.GetContactList();

            oldContacts.RemoveAt(0);
            Assert.AreEqual(newContacts.Count, oldContacts.Count);
        }
    }
}

