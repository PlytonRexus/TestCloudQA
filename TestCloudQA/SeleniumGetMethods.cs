using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestCloudQA
{
    class SeleniumGetMethods
    {
        public static string? GetText(IWebDriver driver, string identifier, string identifierType)
        {
            if (identifierType == "Id")
                return driver.FindElement(By.Id(identifier)).Text;
            else if (identifierType == "Name")
                return driver.FindElement(By.Name(identifier)).Text;
            else if (identifierType == "CssSelector")
                return driver.FindElement(By.CssSelector(identifier)).Text;

            return null;
        }

        public static string? GetSelectedDropdown(IWebDriver driver, string identifier, string identifierType)
        {
            if (identifierType == "Id")
                return new SelectElement(driver.FindElement(By.Id(identifier))).SelectedOption.Text;
            else if (identifierType == "Name")
                return new SelectElement(driver.FindElement(By.Name(identifier))).SelectedOption.Text;
            else if (identifierType == "CssSelector")
                return new SelectElement(driver.FindElement(By.CssSelector(identifier))).SelectedOption.Text;

            return null;
        }
    }
}
