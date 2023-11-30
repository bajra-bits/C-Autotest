using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShoppingCart.PageObjects;
using ShoppingCart.PageObjects.cart;
using ShoppingCart.PageServices.cart;
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


        public OrderConfirm MakePayment()
        {
            EnterText(By.CssSelector(cpo.nameOnCardCssSelector), "supertest"); 
            EnterText(By.CssSelector(cpo.cardNumberCssSelector), "321321321"); 
            EnterText(By.CssSelector(cpo.cvcCssSelector), "3123"); 
            EnterText(By.CssSelector(cpo.expiryMonthCssSelector), "12"); 
            EnterText(By.CssSelector(cpo.expiryYearCssSelector), "2021");

            // make payment
            BtnClick(By.CssSelector(cpo.payBtnCssSelector));
            return new OrderConfirm(siteDriver, wait, new OrderConfirmPageObject());
        }




        public void HelloLanding()
        {
            Console.WriteLine("Hello Landing!"); 
        }

    }

  
}
