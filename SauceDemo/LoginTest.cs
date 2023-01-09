using OpenQA.Selenium;
using SauceDemo.Base;

namespace SauceDemo
{
    public class LoginTests : SauceDemoWrapper
    {
        [Test]
        public void Test1()
        {
            driver.FindElement(By.Name("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Name("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

            String actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }
    }
}