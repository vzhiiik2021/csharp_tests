using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("group 5")
            {
                //Header = "header 5",
                //Footer = "footer 5"
                Header = null,
                Footer = null
            };
            app.Navigator.GoToGroupsPage();
            app.Groups.IfEmptyGroup(1);
            app.Groups.Modify(1, newData);
        }
    }
}
