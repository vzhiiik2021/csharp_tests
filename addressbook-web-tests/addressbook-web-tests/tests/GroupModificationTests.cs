using NUnit.Framework;
using System.Collections.Generic;

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
            app.Groups.IfEmptyGroup(0);

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Modify(0, newData);                        
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
            //Assert.AreEqual(newGroups.Count, oldGroups.Count + 1);
        }
    }
}
