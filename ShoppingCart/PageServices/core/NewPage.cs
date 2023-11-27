using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShoppingCart.PageObjects.core;

namespace ShoppingCart.PageServices.core
{
    public class NewPage<T>
    {
        public IWebDriver siteDriver;
        public IWait<IWebDriver> wait;
        public PageObject<T> pageObject;

        public NewPage(IWebDriver siteDriver, IWait<IWebDriver> wait, PageObject<T> pageObject)
        {
            this.siteDriver = siteDriver;
            this.wait = wait;
            this.pageObject = pageObject;
        }

    }
}
