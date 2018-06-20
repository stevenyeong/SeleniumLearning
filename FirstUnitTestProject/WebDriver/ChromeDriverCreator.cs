using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace FirstUnitTestProject.WebDriver
{
    public class ChromeDriverCreator : IWebDriver<ChromeDriver>
    {
        public ChromeDriver Create()
        {
            return new ChromeDriver();
        }
    }
}
