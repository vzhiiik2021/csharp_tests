using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
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
            app.Groups.Modify(1, newData);
        }
    }
}
