using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using System;


namespace zaliczenie_testy
{
    class Program
    {
        PageObj page;

        [SetUp]

        [Obsolete]
        public void Initialize()
        {
            PropCol.Driver = new ChromeDriver();
            PropCol.Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form/");
            page = new PageObj();
        }
        [Test]
        public void Test1_GetFirstText()
        {
            SelGetMet.GetText("demo-frame", ElementType.@class);
            Console.WriteLine(SelGetMet.GetText("demo-frame", ElementType.@class));
        }
        [Test]
        public void Test2_PartialLink_Click()
        {
            SelGetMet.PartialLink("Partial Link Test", ElementType.partiallinktext);
        }
        [Test]
        public void Test3_LinkTest()
        {
            SelGetMet.Link("Link Test", ElementType.linktext);
        }
        [Test]
        [Obsolete]
        public void Test4_FillNameAndLastname_Janek_Jankowski()
        {
            page.PersonData("Janek", "Jankowski");
        }
        [Test]
        public void Test5_Click_SimpleButton()
        {
            SelSetMet.Click_SimpleButton("buttonwithclass", ElementType.id);
        }
        [Test]
        public void Test6_ClickRadio_Sex()
        {
            SelSetMet.ClickRadio_Sex("sex-1", ElementType.id);
        }
        [Test]
        public void Test7_InputDate()
        {
            page.InputDate("14 Maja 2020");
        }
        [Test]
        public void Test8_MultiPick()
        {
            SelSetMet.MultiplePicker("tool-0", "tool-1", ElementType.id);
        }
        [Test]
        public void Test9_SelectContinet_Europe()
        {
            SelSetMet.SelectDropDown("continents", "Europe", ElementType.id);
        }

        [TearDown]
        public void CleanUp()
        {
            PropCol.Driver.Dispose();
        }

        static void Main(string[] args)
        {
        }
    }
}