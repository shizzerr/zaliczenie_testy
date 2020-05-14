using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace zaliczenie_testy
{
    class SelSetMet
    {


        internal static void MultiplePicker(string element, string element2, ElementType elementType)
        {
            if (elementType == ElementType.id)
                PropCol.Driver.FindElement(By.Id(element)).Click();
            if (elementType == ElementType.id)
                PropCol.Driver.FindElement(By.Id(element2)).Click();
        }

        internal static void ClickRadio_Sex(string element, ElementType elementType)
        {
            if (elementType == ElementType.id)
                PropCol.Driver.FindElement(By.Id(element)).Click();
        }


        public static void Click_SimpleButton(string element, ElementType elementType)
        {
            if (elementType == ElementType.id)
                PropCol.Driver.FindElement(By.Id(element)).Click();
            if (elementType == ElementType.@class)
                PropCol.Driver.FindElement(By.ClassName(element)).Click();
            if (elementType == ElementType.name)
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