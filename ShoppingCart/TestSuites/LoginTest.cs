using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShoppingCart.PageServices;
using ShoppingCart.Utils;

namespace ShoppingCart.TestSuites
{
    public class LoginTest
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
        public void LoginWithValidCreds()
        {
            wait = MyDriver.InitWait(driver);
            driver.Title.CheckPageTitle("Automation Exercise"); 
            var loginPage = new LoginPage(driver, wait, new PageObjects.LoginPageObject());
            loginPage.NavigateToLogin()
                .CheckPageTitle("Automation Exercise - Signup / Login")
                .Login();
        }


        [TearDown]
        public void TearDown()
        {
            //driver.Quit(); 
        }
    }
}
