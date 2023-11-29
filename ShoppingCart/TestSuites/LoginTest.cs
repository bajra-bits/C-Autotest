using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShoppingCart.PageServices;
using ShoppingCart.Utils;

namespace ShoppingCart.TestSuites
{
    [TestFixture]
    public class LoginTest
    {
        IWebDriver driver;
        IWait<IWebDriver> wait;

        [OneTimeSetUp]
        public void Setup()
        {
            // Maximize the browser window
            driver = MyDriver.InitDriver();
            wait = MyDriver.InitWait(driver);
        }

        [SetUp]
        public void Init()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://automationexercise.com/");
            driver.Title.CheckPageTitle("Automation Exercise"); 
        }

        [Test, Order(3)]
        public void LoginWithValidCreds()
        {
            var loginPage = new LoginPage(driver, wait, new PageObjects.LoginPageObject());
            loginPage.NavigateToLogin()
                .CheckPageTitle("Automation Exercise - Signup / Login")
                .Login("supersonic@getnada.com", "supertest")
                ?.Logout();
        }

        [Test, Order(2)]
        public void LoginWithInvalidValidCreds()
        {
            driver.Title.CheckPageTitle("Automation Exercise"); 
            var loginPage = new LoginPage(driver, wait, new PageObjects.LoginPageObject());
            loginPage.NavigateToLogin()
                .CheckPageTitle("Automation Exercise - Signup / Login")
                .Login("supertest@getnada.com","supertest@getnada.com");
        }

        [Test, Order(1)]
        public void LoginWithInvalidValidUser()
        {
            driver.Title.CheckPageTitle("Automation Exercise"); 
            var loginPage = new LoginPage(driver, wait, new PageObjects.LoginPageObject());
            loginPage.NavigateToLogin()
                .CheckPageTitle("Automation Exercise - Signup / Login")
                .Login("invaliduser@getnada.com","supertest");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
