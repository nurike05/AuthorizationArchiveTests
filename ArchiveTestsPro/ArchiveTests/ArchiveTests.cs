using ArchiveTests.PageObjects;
using OpenQA.Selenium;

namespace ArchiveTests
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://archive.org");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObject(driver);
            mainMenu
                .SignIn()
                .Login(UserNameForTests.LOGIN, UserNameForTests.PASSWORD);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}