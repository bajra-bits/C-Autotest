using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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
            var registerPage = new RegisterPage(driver, wait, new PageObjects.RegisterPageObject());
            var pageTitle = driver.Title;
            pageTitle.CheckPageTitle("Automation Exercise"); 

            registerPage.NavigateToSignup().CheckPageTitle("Automation Exercise - Signup / Login").Register();
        }

        [TearDown] public void TearDown()
        {
            //driver.Quit(); 
        }
    }
}
