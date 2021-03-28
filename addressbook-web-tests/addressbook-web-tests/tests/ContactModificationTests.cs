using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Ivan", "Ivanov")
            {
                Title = "Mr",
                Company = "Kuku",
                Mobile = "111111",
                Email = "sss@hh.com",
                Address = "Teststreet 200, 22222, Testcity"
            };
            app.Contacts.IfEmptyContact(1);
            List<ContactData> oldContacts = app.Contacts.GetContactList();
            app.Contacts.Modify(newData);           
            List<ContactData> newContacts = app.Contacts.GetContactList();            
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
