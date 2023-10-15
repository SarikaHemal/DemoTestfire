using DemoTestFireTest.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTestFireTest.Pages
{
    public class MainPage
    {
        private IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string SuccessUserDisplay() {
            string username=driver.FindElement(By.XPath("//h1[contains(text(),'')]")).Text;
            return username;
        }
       
    }
}
