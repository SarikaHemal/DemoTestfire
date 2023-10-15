
using CsvHelper;
using DemoTestfire.Utility;
using DemoTestFireTest.Utility;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTestfireTest.Global
{
    public class Base
    {
        public static IWebDriver driver { set; get; }
        public void Initialize()
        {
            switch (Settings.Browser)
            {

                case "FireFox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    break;
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void NavigateToPage(String Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

       
    }
      
}
        
    

