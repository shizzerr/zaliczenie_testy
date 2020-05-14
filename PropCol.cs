using OpenQA.Selenium;

namespace zaliczenie_testy
{
    enum ElementType { name, @class, id, value, partiallinktext, linktext }

    class PropCol
    {
        public static IWebDriver Driver { get; set; }
    }
}
