using OpenQA.Selenium;
using SauceDemo.Base;
using SauceDemo.Pages;
using SauceDemo.Utilities;

namespace SauceDemo
{
    public class LoginTests : SauceDemoWrapper
    {
        [Test]
        public void ValidLoginTest()
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.EnterUserName("standard_user");
            loginpage.EnterPassword("secret_sauce");
            loginpage.ClickOnLogin();


            string actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [Test, TestCaseSource(typeof(DataSaurce), nameof(DataSaurce. InvalidLoginTestData))]
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            LoginPage loginpage = new LoginPage(driver);

            loginpage.EnterUserName(username);
            loginpage.EnterPassword(password);
            loginpage.ClickOnLogin();

            string actualError = loginpage.GetInvalidErrorMassage();

            Assert.That(actualError.Contains(expectedError), "Assertion on error msg");
        }
    }
}