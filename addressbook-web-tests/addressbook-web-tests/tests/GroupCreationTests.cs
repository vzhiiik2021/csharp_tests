using NUnit.Framework;
namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {     
        [Test]
        public void GroupCreationTest()
        {             
            //FillGroupForm(new GroupData("group 1")); один обязательный параметр
            //FillGroupForm(new GroupData("group 1", "header 1", "footer 1")); несколько обязательных параметров
            //универсальный вариант:
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