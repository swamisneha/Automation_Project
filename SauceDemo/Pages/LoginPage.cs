
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SauceDemo.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void EnterUserName(string username)
        {
            driver.FindElement(By.Name("user-name")).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(By.Name("password")).SendKeys(password);
        }
        public void ClickOnLogin()
        {
            driver.FindElement(By.Id("login-button")).Click();
        }
        public string GetInvalidErrorMassage()
        {
            return driver.FindElement(By.XPath("//h3[contains(text(),'Epic sadfa')]")).Text;
        }
    }
}
