﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidomiRegisterPOMDemo.Pages
{
    public class BasePage
    {
        //here we declare chrome driver
        private IWebDriver driver;
        private WebDriverWait wait;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            //driver.Manage().Window.Maximize();
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }
        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }
        public WebDriverWait Wait
        {
            get
            {
                return this.wait;
            }
        }

    }
}
