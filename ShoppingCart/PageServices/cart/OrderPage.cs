using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using ShoppingCart.PageObjects.cart;
using ShoppingCart.PageServices.core;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.PageServices
{
    public class OrderPage: NewPage<OrderPage,OrderPageObject>
    {
        OrderPageObject cpo;

        public OrderPage(IWebDriver siteDriver, IWait<IWebDriver> wait, OrderPageObject pageObject) : base(siteDriver, wait, pageObject)
        {
            cpo = (OrderPageObject)pageObject;
        }



        public CardDetails ConfirmOrder()
        {
            var element = siteDriver.FindElement(By.LinkText(cpo.PlaceOrderLinkText));
            ScrollIntoViewAction(element);
            BtnClick(element);
            return new CardDetails(siteDriver, wait, new CardDetailsPageObject());
        }



        public void HelloLanding()
        {
            Console.WriteLine("Hello Landing!"); 
        }

    }

  
}
