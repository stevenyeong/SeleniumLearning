using FirstUnitTestProject.WebDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace FirstUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FireFoxTest()
        {
            GenericTest(new FirefoxDriverCreator().Create());

        }

        [TestMethod]
        public void ChromeTest()
        {
            GenericTest(new ChromeDriverCreator().Create());
        }

        private void GenericTest(IWebDriver driver)
        {

            //Notice navigation is slightly different than the Java version
            //This is because 'get' is a keyword in C#
            driver.Navigate().GoToUrl("http://www.google.com/");

            // Find the text input element by its name
            IWebElement query = driver.FindElement(By.Name("q"));

            // Enter something to search for
            query.SendKeys("Cheese");

            // Now submit the form. WebDriver will find the form for us from the element
            query.Submit();

            // Google's search is rendered dynamically with JavaScript.
            // Wait for the page to load, timeout after 10 seconds
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.StartsWith("cheese", StringComparison.OrdinalIgnoreCase));

            // Should see: "Cheese - Google Search" (for an English locale)
            Console.WriteLine("Page title is: " + driver.Title);

        }
    }
}
