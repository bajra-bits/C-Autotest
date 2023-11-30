using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using ShoppingCart.PageObjects;
using ShoppingCart.PageObjects.cart;
using ShoppingCart.PageServices.core;

namespace ShoppingCart.PageServices.cart
{
    public class OrderConfirm : NewPage<OrderConfirm, OrderConfirmPageObject>
    {
        OrderConfirmPageObject cpo;

        public OrderConfirm(IWebDriver siteDriver, IWait<IWebDriver> wait, OrderConfirmPageObject pageObject) : base(siteDriver, wait, pageObject)
        {
            cpo = pageObject;
        }


        public LandingPage Continue()
        {
            var confirmationMsg = ElementIsVisisble(By.XPath(cpo.OrderConfirmXPathSelector)); 
            Console.WriteLine(String.Format("Status: {0}", confirmationMsg.Text));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(cpo.ContinueOrderLinkText))).Click();
            return new LandingPage(siteDriver, wait, new LandingPageObject());

        }


        public void HelloLanding()
        {
            Console.WriteLine("Hello Landing!");
        }

    }


}
