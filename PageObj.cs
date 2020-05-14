using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenie_testy
{
    class PageObj
    {
        [Obsolete]
        public PageObj()
        {
            PageFactory.InitElements(PropCol.Driver, this);
        }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Name, Using = "firstname")]
        public IWebElement txtFirstname { get; set; }

        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement txtLastname { get; set; }

       // public void FillForm(string initial)
      //  {
      //      txtInitial.SendKeys(initial);
      //      btnSave.Click();
      //  }

        [Obsolete]
        public PageObj PersonData(string firstname, string lastname)
        {
            txtFirstname.SendKeys(firstname);
            txtLastname.SendKeys(lastname);
            return new PageObj();
        }

    }
}
