using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FirstUnitTestProject.WebDriver
{
    public interface IWebDriver<out T> where T : IWebDriver
    {
        T Create();
    }
}
