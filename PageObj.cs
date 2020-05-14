using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace zaliczenie_testy
{
    class PageObj
    {
        [Obsolete]
        public PageObj()
        {
            PageFactory.InitElements(PropCol.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "datepicker")]
        public IWebElement txtDate { get; set; }

        [FindsBy(How = How.Name, Using = "firstname")]
        public IWebElement txtFirstname { get; set; }

        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement txtLastname { get; set; }

        public void InputDate(string value)
        {
            txtDate.SendKeys(value);
        }

        [Obsolete]
        public PageObj PersonData(string firstname, string lastname)
        {
            txtFirstname.SendKeys(firstname);
            txtLastname.SendKeys(lastname);
            return new PageObj();
        }

    }
}
