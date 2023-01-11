
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
        private By _usernameLocator = By.Name("user-name");
        private By _passwordLocator = By.Name("password");
        private By _loginLocator = By.Id("login-button");
        private By _ErrorLocator = By.XPath("//h3[contains(text(),'Epic sadfa')]");

        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void EnterUserName(string username)
        {
            driver.FindElement(_usernameLocator).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(_passwordLocator).SendKeys(password);
        }
        public void ClickOnLogin()
        {
            driver.FindElement(_loginLocator).Click();
        }
        public string GetInvalidErrorMassage()
        {
            return driver.FindElement(_ErrorLocator).Text;
        }
    }
}
