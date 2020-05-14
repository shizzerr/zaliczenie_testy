using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenie_testy
{
    class SelGetMet
    {
        public static string GetText(string element, ElementType elementType)
        {
            if (elementType == ElementType.@class)
                return PropCol.Driver.FindElement(By.ClassName(element)).GetAttribute("value");
            if (elementType == ElementType.@class)
                return PropCol.Driver.FindElement(By.ClassName(element)).GetAttribute("value");
            return String.Empty;
        }

        public static string GetTextFromDDL(string element, ElementType elementType)
        {
            if (elementType == ElementType.id)
                return new SelectElement(PropCol.Driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == ElementType.name)
                return new SelectElement(PropCol.Driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            return String.Empty;
        }
    }
}
