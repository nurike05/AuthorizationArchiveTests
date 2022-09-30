using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveTests.PageObjects
{
    public class AuthorizatonPageObject
    {
        private IWebDriver driver;

        private readonly By _signInLoginButton = By.XPath("//input[@name='username']");
        private readonly By _signInPasswordButton = By.XPath("//input[@name='password']");
        private readonly By _selectCheckbox = By.XPath("//input[@name='remember']");
        private readonly By _pressLoginButton = By.XPath("//input[@type='submit']");

        public AuthorizatonPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public MainMenuPageObject Login(string login, string password)
        {
            driver.FindElement(_signInLoginButton).SendKeys(UserNameForTests.LOGIN);
            driver.FindElement(_signInPasswordButton).SendKeys(UserNameForTests.PASSWORD);
            driver.FindElement(_selectCheckbox).Click();
            driver.FindElement(_pressLoginButton).Click();

            return new MainMenuPageObject(driver);
        }
    }
}
