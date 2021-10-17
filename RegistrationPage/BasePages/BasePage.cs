﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GANUIAssignment.RegistrationPage.BasePages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = (IWebDriver)driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
        }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public  IWebElement ScrollTo( IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
    }
}
