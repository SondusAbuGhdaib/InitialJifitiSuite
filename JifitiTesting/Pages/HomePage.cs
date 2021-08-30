using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace JifitiTesting.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver WebDriver)
        {
            Driver = WebDriver;
        }
        private IWebDriver Driver { get; }


        public IWebElement LoginLink => Driver.FindElement(By.LinkText("Login"));
        IWebElement EmployeeDetailsLink => Driver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => LoginLink.Click();

        public bool IsEmployeeDetailsExist() => EmployeeDetailsLink.Displayed;

    }
}
