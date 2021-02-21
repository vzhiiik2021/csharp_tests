using NUnit.Framework;
namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {     
        [Test]
        public void GroupCreationTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToGroupsPage();
            groupHelper.InitGroupCreation();
            //FillGroupForm(new GroupData("group 1")); один обязательный параметр
            //FillGroupForm(new GroupData("group 1", "header 1", "footer 1")); несколько обязательных параметров
            //универсальный вариант:
            GroupData group = new GroupData("group 1")
            {
                Header = "header 1",
                Footer = "footer 1"
            };
            groupHelper.FillGroupForm(group);
            groupHelper.SubmitGroupCreation();
            navigator.ReturnToGroupsPage();
            loginHelper.Logout();
        }   
    }
}