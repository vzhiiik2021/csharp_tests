using NUnit.Framework;
namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {     
        [Test]
        public void GroupCreationTest()
        {   
            GroupData group = new GroupData("group 1")
            {
                Header = "header 1",
                Footer = "footer 1"
            };
            app.Navigator.GoToGroupsPage();
            app.Groups.Create(group);                          
        }
        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("")
            {
                Header = "",
                Footer = ""
            };
            app.Navigator.GoToGroupsPage();
            app.Groups.Create(group);
        }
    }
}