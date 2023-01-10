using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Base
{
    public class SauceDemoWrapper
    {
        protected IWebDriver driver;
        [SetUp]
        public void BeforeMethod()
        {
            string browserName = "";
            if (browserName.ToLower().Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            else if (browserName.ToLower().Equals("firefox"))
            {
                driver = new EdgeDriver();
            }
            else
            {
                driver = new ChromeDriver();

            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = ("https://www.saucedemo.com/");
        }
        
        [TearDown]
        public void AfterMethod()
        {
            driver.Quit();
        }
    }
}
