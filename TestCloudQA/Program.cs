using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

/**
 * Write a program or algorithm using C# and Selenium to automatically test any three fields on that page.
 * The main goal of your program is to make sure it still works even if the position or any other properties 
 * of the HTML elements for those three fields change.
 */

/**
 * #automationtestform > div:nth-child(4) > button:nth-child(2)
 * #fname
 * #state
 */

namespace TestCloudQA
{
    class Program
    {
        readonly IWebDriver driver = new EdgeDriver();
        //static void Main(String[] _args) { }

        [SetUp]
        public void Initialise()
        {
            driver.Navigate().GoToUrl("http://app.cloudqa.io/home/AutomationPracticeForm");
        }

        [Test]
        public void ExecuteTextboxTest()
        {
            SeleniumSetMethods.Click(driver, "fname", "Id");
            SeleniumSetMethods.EnterText(driver, "fname", "Id", "Lambda");
            Console.WriteLine("Value from #fname is: " + SeleniumGetMethods.GetText(driver, "fname", "Id"));
        }

        [Test]
        public void ExecuteDropdownTest()
        {
            SeleniumSetMethods.SelectDropdown(driver, "state", "Id", "India");
            Console.WriteLine("Value from #state is: " + SeleniumGetMethods.GetSelectedDropdown(driver, "state", "Id"));
        }

        [Test]
        public void ExecuteSubmitButtonTest()
        {
            SeleniumSetMethods.Click(driver, "#automationtestform > div:nth-child(4) > button:nth-child(1)", "CssSelector");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
