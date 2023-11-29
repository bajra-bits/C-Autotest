using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ShoppingCart.PageObjects.core;
using ShoppingCart.Utils;

namespace ShoppingCart.PageServices.core
{
    public class NewPage<T,U>
    {
        public IWebDriver siteDriver;
        public IWait<IWebDriver> wait;
        public PageObject<U> pageObject;
        public IJavaScriptExecutor jsExecutor;

        public NewPage(IWebDriver siteDriver, IWait<IWebDriver> wait, PageObject<U> pageObject)
        {
            this.siteDriver = siteDriver;
            this.wait = wait;
            this.pageObject = pageObject;
            this.jsExecutor = (IJavaScriptExecutor)siteDriver;
        }



        protected void ScrollIntoView(int x, int y)
        {
            jsExecutor.ExecuteScript(String.Format("window.scrollBy({0}, {1});", x, y));
        }


        protected void ScrollToBottom()
        {
            jsExecutor.ExecuteScript("window.scrollTo({ top: document.body.scrollHeight, behavior: 'smooth' });");

        }



        protected IWebElement ScrollIntoViewAction(IWebElement element)
        {
            var actions = new Actions(siteDriver);
            actions.MoveToElement(element);
            actions.Perform();
            return element;
        }

      /*  public T? CheckPageTitle(string expected)
        {
            expected.CheckPageTitle(siteDriver.Title);
            return default;
        }*/

    }
}
