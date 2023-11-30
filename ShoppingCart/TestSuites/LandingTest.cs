using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShoppingCart.PageServices;
using ShoppingCart.Utils;

namespace ShoppingCart.TestSuites
{
    [TestFixture]
    public class LandingTest
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


        [Test, Order(1)]
        public void AddProductToCart()
        {
            var landingPage = new LandingPage(driver, wait, new PageObjects.LandingPageObject());
            landingPage
                .AddProductToCart(0)
                .AddProductToCart(1)
                .AddProductToCart(2)
                .AddProductToCart(3)
                .GoToCart()
                .Checkout()
                .ConfirmOrder()
                .MakePayment()
                .Continue(); 
        }


        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
