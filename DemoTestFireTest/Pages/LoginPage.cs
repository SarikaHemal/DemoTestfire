using DemoTestfireTest.Global;
using DemoTestFireTest.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTestFireTest.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement UsernameTextbox => driver.FindElement(By.Id("uid"));
        private IWebElement PasswordTextbox => driver.FindElement(By.Id("passw"));
        private IWebElement LoginButton => driver.FindElement(By.XPath("//input[@name='btnSubmit']"));
        private IWebElement LoginFailedError => driver.FindElement(By.XPath("//span[contains(text(),'Login Failed')]"));
        public MainPage SuccessLogin(string username, string password)
        {
            UsernameTextbox.SendKeys(username);
            PasswordTextbox.SendKeys(password);
            LoginButton.Click();
            return new MainPage(driver);
        }
        public bool ValidateLoginFailedErrorMessage()
        {
            return LoginFailedError.Displayed;
        }

    }
}
