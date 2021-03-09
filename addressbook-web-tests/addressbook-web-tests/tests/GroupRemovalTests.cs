using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {     
        [Test]
        public void GroupRemovalTest()
        {
            //prepare
            app.Navigator.GoToGroupsPage();
            app.Groups.IfEmptyGroup(1);

            //action
            app.Groups.Remove(1);            
        }             
    }
}

