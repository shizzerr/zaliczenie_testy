using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaliczenie_testy
{
    class Program
    {
        //IWebDriver driver = new ChromeDriver();
        PageObj page;

        static void Main(string[] args)
        {

        }

        [SetUp]
        [Obsolete]
        public void Initialize()
        {
            PropCol.Driver = new ChromeDriver();
            PropCol.Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form/");
            page = new PageObj();
        }

        [Test]
        [Obsolete]
        public void FillNameAndLastname_Janek_Jankowski()
        {
            //page.FillForm("koronawirus");
            page.PersonData("Janek", "Jankowski");
            //Console.WriteLine("Tytuł to: " + SeleniumGetMethods.GetTextFromDDL("TitleId", ElementType.Id));

            //SeleniumSetMethods.EnterText("Initial", "koronawirus", ElementType.Name);

            //Console.WriteLine("Initial to: " + SeleniumGetMethods.GetText("Initial", ElementType.Name));

            //SeleniumSetMethods.Click("Save", ElementType.Name);
        }

        [Test]
        public void SelectContinet_Europe()
        {
            SelSetMet.SelectDropDown("continents", "Europe", ElementType.id);
        }

        [Test]
        public void GetFirstText()
        {
            SelGetMet.GetText("demo-frame", ElementType.@class);
        }


        [TearDown]
        public void CleanUp()
        {
            PropCol.Driver.Dispose();
        }

    }
}