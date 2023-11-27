using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ShoppingCart.Utils
{
    public class MyDriver
    {
        public static IWebDriver? siteDriver;
        public static IWait<IWebDriver>? wait;


        public static IWebDriver InitDriver()
        {
            if (siteDriver == null)
            {
                siteDriver = new ChromeDriver();
            }

            return siteDriver;
        }

        public static IWait<IWebDriver> InitWait(IWebDriver driver)
        {
            if (wait == null)
            {
                wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(3000));

            }

            return wait;
        }
    }



}
