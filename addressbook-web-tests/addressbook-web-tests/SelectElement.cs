using System;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    internal class SelectElement
    {
        private IWebElement webElement;        

        public SelectElement(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        internal void SelectByText(string v)
        {
            string fieldValue = v;
        }
    }
}