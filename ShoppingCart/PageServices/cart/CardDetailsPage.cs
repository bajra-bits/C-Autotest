using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShoppingCart.PageObjects;
using ShoppingCart.PageObjects.cart;
using ShoppingCart.PageServices.core;

namespace ShoppingCart.PageServices
{
    public class CardDetails: NewPage<CardDetails,CardDetailsPageObject>
    {
        CardDetailsPageObject cpo;

        public CardDetails(IWebDriver siteDriver, IWait<IWebDriver> wait, CardDetailsPageObject pageObject) : base(siteDriver, wait, pageObject)
        {
            cpo = (CardDetailsPageObject)pageObject;
        }




        public void HelloLanding()
        {
            Console.WriteLine("Hello Landing!"); 
        }

    }

  
}
