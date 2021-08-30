using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace JifitiTesting.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver WebDriver)
        {
            Driver = WebDriver;
        }
        private IWebDriver Driver { get; }

        IWebElement UserName => Driver.FindElement(By.Name("UserName"));
        IWebElement Password => Driver.FindElement(By.Name("Password"));
        IWebElement LoginBtn => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void Login(string username, string password)
        {
            UserName.SendKeys(username);
            Password.SendKeys(password);
            LoginBtn.Submit();
        }



    }
}
