using DemoTestfire.Utility;
using DemoTestfireTest.Global;
using DemoTestFireTest.Pages;
using DemoTestFireTest.Utility;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTestfireTest.Tests
{
    public class LoginPageTest: Base
    {
                
        [SetUp] 
        public void SetUp()
        {
            //Initiaze browser and navigate to  Login Page
            Initialize();
            NavigateToPage(Settings.Url);
        }

        [Test]
        public void ValidateSuccessfulLoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            MainPage mainPage = loginPage.SuccessLogin("Admin", "Admin");
            string username = mainPage.SuccessUserDisplay();
            Assert.IsTrue(username.Contains("Admin"));

                
        }

        [Test, TestCaseSource(nameof(TestDataFromCSV))]
        public void ReadDataFromCSVFileTest(UserDetails userDetails)
        {
            LoginPage loginPage = new LoginPage(driver);
            Console.WriteLine($"Username: {userDetails.Username}, Password: {userDetails.Password}");
            MainPage mainPage = loginPage.SuccessLogin(userDetails.Username, userDetails.Password);
            string username = mainPage.SuccessUserDisplay();
            if (username.Contains("Admin"))
            {
                Assert.Pass();
            }
            else if (loginPage.ValidateLoginFailedErrorMessage())
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
         }




        public static IEnumerable<UserDetails> TestDataFromCSV()
        {
            string csvFilePath = "C:\\Sarika\\Oritain\\DemoTestfire\\DemoTestFireTest\\TestData\\TestData.csv";
            List<UserDetails> userDetailsList = CSVReader.LoadUserDetailsFromCsv(csvFilePath);

            foreach (var userDetails in userDetailsList)
            {
                yield return userDetails;
            }
        }


        
        [TearDown]
        public void TearDown()
        {
            
            driver.Quit();
        }
    }
    
}
