using OpenQA.Selenium;
using System;

namespace zaliczenie_testy
{
    class SelGetMet
    {
        public static string GetText(string element, ElementType elementType)
        {
            if (elementType == ElementType.@class)
                return PropCol.Driver.FindElement(By.ClassName(element)).Text;
            return String.Empty;
        }

        internal static void PartialLink(string element, ElementType elementType)
        {
            if (elementType == ElementType.partiallinktext)
                PropCol.Driver.FindElement(By.PartialLinkText(element)).Click();
        }

        internal static void Link(string element, ElementType elementType)
        {
            if (elementType == ElementType.linktext)
                PropCol.Driver.FindElement(By.LinkText(element)).Click();
        }
    }
}
