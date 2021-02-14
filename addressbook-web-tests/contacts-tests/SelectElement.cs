using System;
using OpenQA.Selenium;

namespace contacts_tests
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