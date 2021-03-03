using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {     
        [Test]
        public void ContactRemovalTest()
        {             
            app.Contacts.Remove(1, true);  
        }
    }
}

