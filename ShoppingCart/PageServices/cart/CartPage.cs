using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using ShoppingCart.PageObjects.cart;
using ShoppingCart.PageServices.core;

namespace ShoppingCart.PageServices.cart
{
    public class CartPage : NewPage<CartPage, CartPageObject>
    {
        CartPageObject cpo;

        public CartPage(IWebDriver siteDriver, IWait<IWebDriver> wait, CartPageObject pageObject) : base(siteDriver, wait, pageObject)
        {
            cpo = pageObject;
        }


        public OrderPage Checkout()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(cpo.CheckoutLinkText))).Click();
            return new OrderPage(siteDriver, wait, new OrderPageObject());

        }


        public void HelloLanding()
        {
            Console.WriteLine("Hello Landing!");
        }

    }


}
