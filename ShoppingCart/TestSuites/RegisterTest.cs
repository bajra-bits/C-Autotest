using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShoppingCart.PageServices;
using ShoppingCart.Utils;

namespace ShoppingCart.TestSuites
{
    public class RegisterTest
    {
        IWebDriver driver;
        IWait<IWebDriver> wait; 

        [SetUp]
        public void Setup()
        {
            // Maximize the browser window
            driver = MyDriver.InitDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://automationexercise.com/");

        }

        [Test]
        public void Register()
        {
            wait = MyDriver.InitWait(driver);
            driver.Title.CheckPageTitle("Automation Exercise"); 

            var registerPage = new RegisterPage(driver, wait, new PageObjects.RegisterPageObject());
            registerPage.NavigateToSignup()
                .CheckPageTitle("Automation Exercise - Signup / Login")
                .Register();
        }

        [TearDown] public void TearDown()
        {
            driver.Quit();
        }
    }
}
