using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveTests.PageObjects
{
    public class MainMenuPageObject
    {
        private IWebDriver driver;

        public MainMenuPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public AuthorizatonPageObject SignIn()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            WebElement shadowdom1 = (WebElement)js.ExecuteScript("return document" +
                ".querySelector('app-root').shadowRoot.querySelector('header')" +
                ".querySelector('ia-topnav').shadowRoot.querySelector('div')" +
                ".querySelector('primary-nav').shadowRoot.querySelector('nav')");
            WebElement userInfo = (WebElement)shadowdom1.FindElement(By.CssSelector("div.user-info"));
            WebElement loginButton = (WebElement)userInfo.FindElement(By.TagName("login-button"));
            WebElement shadowdom2 = (WebElement)js.ExecuteScript("return arguments[0].shadowRoot.querySelector('div')", loginButton);
            WebElement span = (WebElement)shadowdom2.FindElement(By.TagName("span"));
            span.FindElement(By.CssSelector("a[href='/account/login']")).Click();
            return new AuthorizatonPageObject(driver);
        }
    }
}
