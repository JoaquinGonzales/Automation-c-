using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingForAutomationClass
{
    public abstract class WebDriverBase
    {
        public IWebDriver driver;
        public WebDriverBase()
        {
            driver = new ChromeDriver(@"C:\Users\joaquin.gonzales\Desktop\drivers");
        }
    }
}
