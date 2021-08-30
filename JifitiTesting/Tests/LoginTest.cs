using JifitiTesting.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace JifitiTesting.Tests
{
    class LoginTest
    {
        //Browser driver
        IWebDriver WebDriver = new ChromeDriver(@"C:\SelAssets\ChromeDriver");
        [SetUp]
        public void Setup()
        {
          
            WebDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Test]
        public void Login()
        {
            HomePage home = new HomePage(WebDriver);
            home.ClickLogin();
            LoginPage login = new LoginPage(WebDriver);
            login.Login("admin","password");
            Assert.That(home.IsEmployeeDetailsExist, Is.True);//make sure that the Employee Details page has been appeared


        }
        [TearDown]
        public void TearDown() => WebDriver.Quit();
    }
}
