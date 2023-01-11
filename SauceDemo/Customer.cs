using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SauceDemo.Base;
using SauceDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SauceDemo
{
    public class Customer : SauceDemoWrapper
    {
        [Test]
        public void addToCart()
        {
            LoginPage loginpage = new LoginPage(driver);

            loginpage.EnterUserName("standard_user");
            loginpage.EnterPassword("secret_sauce");
            loginpage.ClickOnLogin();

            driver.FindElement(By.XPath("//button[contains(@id,'add-to-cart-sauce-labs-bolt-t-shirt')]")).Click();
            driver.FindElement(By.XPath("//a[@class='shopping_cart_link']")).Click();
            driver.FindElement(By.XPath("//button[@class='btn btn_action btn_medium checkout_button']")).Click();

            driver.FindElement(By.Name("firstName")).SendKeys("john");
            driver.FindElement(By.Name("lastName")).SendKeys("wick");
            driver.FindElement(By.Name("postalCode")).SendKeys("411 012");
            driver.FindElement(By.Id("continue")).Click();
            driver.FindElement(By.Id("finish")).Click(); //Add to cart done

            driver.FindElement(By.Id("react-burger-menu-btn")).Click();
            driver.FindElement(By.Id("about_sidebar_link")).Click();
            driver.FindElement(By.LinkText("Contact")).Click();
            driver.FindElement(By.LinkText("Contact Sales")).Click();
            driver.FindElement(By.Name("FirstName")).SendKeys("john");
            driver.FindElement(By.Name("LastName")).SendKeys("wick");
            driver.FindElement(By.Name("Company")).SendKeys("Maveric");
            driver.FindElement(By.Id("Email")).SendKeys("john123@gmail.com");

            SelectElement selectEmployee = new SelectElement(driver.FindElement(By.Name("Company_Size__c")));
            selectEmployee.SelectByText("101-500");

            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("Country")));
            selectCountry.SelectByText("India");

            driver.FindElement(By.Name("Phone")).SendKeys("8767564356");

            driver.ExecuteJavaScript("document.querySelector('#mktoCheckbox_32744_7').click();\r\n");

            //Actions actions = new Actions(driver);
            //actions.MoveToElement(driver.FindElement(By.XPath("//div[@class='mktoButtonRow']/span/button"))).Build().Perform();

            driver.FindElement(By.Name("How_did_you_hear_about_Sauce_Labs__c")).SendKeys("Sneha S");
            driver.FindElement(By.XPath("//*[@class=\"mktoFieldWrap\"]/textarea")).SendKeys("Sneha");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)", driver.FindElement(By.XPath("//div[@class='mktoButtonRow']/span/button")));

            driver.ExecuteJavaScript("document.querySelector('#mktoCheckbox_32740_0').click();\r\n");
            //driver.FindElement(By.XPath("//button[@class='mktoButton']")).Click();
            driver.ExecuteJavaScript("document.querySelector(\"[class='mktoButton']\").click();\r\n");
            //driver.FindElement(By.XPath("(//button[@type='submit'])[1]")).Click();

        }
    }

    
}
