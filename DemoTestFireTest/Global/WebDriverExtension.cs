﻿using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTestFireTest.Global
{
    public static class WebDriverExtension
    {
        public static IWebElement WaitForElement(this IWebDriver driver, By by, int timeOutInSeconds = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
                return wait.Until(driver => driver.FindElement(by));
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverException($"Wait for Element {by} failed");
            }
        }

    }
}
