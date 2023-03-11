using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestCloudQA
{
    class SeleniumSetMethods
    {
        public static void EnterText(IWebDriver driver, string identifier, string identifierType, string text)
        {
            if (identifierType == "Id")
                driver.FindElement(By.Id(identifier)).SendKeys(text);
            else if (identifierType == "Name")
                driver.FindElement(By.Name(identifier)).SendKeys(text);
            else if (identifierType == "CssSelector")
                driver.FindElement(By.CssSelector(identifier)).SendKeys(text);
        }

        public static void Click(IWebDriver driver, string identifier, string identifierType)
        {
            if (identifierType == "Id")
                driver.FindElement(By.Id(identifier)).Click();
            else if (identifierType == "Name")
                driver.FindElement(By.Name(identifier)).Click();
            else if (identifierType == "CssSelector")
                driver.FindElement(By.CssSelector(identifier)).Click();
        }

        public static void SelectDropdown(IWebDriver driver, string identifier, string identifierType, string text)
        {
            if (identifierType == "Id")
                new SelectElement(driver.FindElement(By.Id(identifier))).SelectByValue(text);
            else if (identifierType == "Name")
                new SelectElement(driver.FindElement(By.Name(identifier))).SelectByValue(text);
            else if (identifierType == "CssSelector")
                new SelectElement(driver.FindElement(By.CssSelector(identifier))).SelectByValue(text);
        }
    }
}
