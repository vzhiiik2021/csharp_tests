using NUnit.Framework;

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
            app.Contacts.Modify(newData);
        }
    }
}
