using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace FirstUnitTestProject.WebDriver
{
    public class FirefoxDriverCreator : IWebDriver<FirefoxDriver>
    {
        public FirefoxDriver Create()
        {
            return new FirefoxDriver();
        }
    }
}
