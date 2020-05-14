using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenie_testy
{
    enum ElementType { name, @class, id, value }

    class PropCol
    {
        public static IWebDriver Driver { get; set; }
    }
}
