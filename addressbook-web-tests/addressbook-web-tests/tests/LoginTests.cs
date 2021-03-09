using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            //prepare
            app.Auth.Logout();

            //action
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);

            //varification
            Assert.IsTrue(app.Auth.IsLoggetIn(account));
        }
        [Test]
        public void LoginWithInvalidCredentials()
        {
            //prepare
            app.Auth.Logout();

            //action
            AccountData account = new AccountData("admin", "12345");
            app.Auth.Login(account);

            //varification
            Assert.IsFalse(app.Auth.IsLoggetIn(account));
        }
    }
}
