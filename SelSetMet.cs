using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenie_testy
{
    class SelSetMet
    {


        internal static void EnterText(string element, string value, ElementType elementType)
        {
            if (elementType == ElementType.id)
                PropCol.Driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == ElementType.name)
                PropCol.Driver.FindElement(By.Name(element)).SendKeys(value);
        }

        public static void Click(string element, ElementType elementType)
        {
            if (elementType == ElementType.id)
                PropCol.Driver.FindElement(By.Id(element)).Click();
            if (elementType == ElementType.@class)
                PropCol.Driver.FindElement(By.Name(element)).Click();
        }
        public static void SelectDropDown(string element, string value, ElementType elementType)
        {
            if (elementType == ElementType.id)
                new SelectElement(PropCol.Driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == ElementType.@class)
                new SelectElement(PropCol.Driver.FindElement(By.ClassName(element))).SelectByText(value);
            if (elementType == ElementType.name)
                new SelectElement(PropCol.Driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}