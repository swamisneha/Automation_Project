﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Pages
{
    public class MainPage
    {

        private IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
