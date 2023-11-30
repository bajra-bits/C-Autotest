using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShoppingCart.PageObjects.cart;
using ShoppingCart.PageServices.core;

namespace ShoppingCart.PageServices
{
    public class OrderPage: NewPage<OrderPage,OrderPageObject>
    {
        OrderPageObject cpo;

        public OrderPage(IWebDriver siteDriver, IWait<IWebDriver> wait, OrderPageObject pageObject) : base(siteDriver, wait, pageObject)
        {
            cpo = (OrderPageObject)pageObject;
        }




        public void HelloLanding()
        {
            Console.WriteLine("Hello Landing!"); 
        }

    }

  
}
