using NUnit.Framework;
using System;
using System.Text;

namespace WebAddressbookTests
{
    public class TestBase
    {       
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = ApplicationManager.GetInstance();
        }

        //[TearDown]
        //public void TeardownTest()
        //{
        //    //app.Auth.Logout();            
        //}   

    }
}
