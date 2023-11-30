using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using ShoppingCart.PageObjects;
using ShoppingCart.PageServices.core;

namespace ShoppingCart.PageServices
{
    public class LandingPage: NewPage<LandingPage,LandingPageObject>
    {
        LandingPageObject cpo;

        public LandingPage(IWebDriver siteDriver, IWait<IWebDriver> wait, LandingPageObject pageObject) : base(siteDriver, wait, pageObject)
        {
            cpo = (LandingPageObject)pageObject;
        }



        public LandingPage ScrollForProducts()
        {
            ScrollIntoView(0, 500);
            return this; 
        }
        public LandingPage AddProductToCart(int index)
        {
            var prodId = index + 1; 
            var productEl = siteDriver.FindElements(By.CssSelector(cpo.productCssSelector))[index];

            ScrollIntoViewAction(productEl); 
            HoverElement(productEl);
            BtnClick(By.CssSelector(String.Format(cpo.addToCartSelector, prodId)));
            ElementIsVisisble(By.CssSelector(cpo.addToCartModal)); 
            BtnClick(By.XPath(cpo.continueShoppingBtnXPathLocator));
            return this; 
        }

        public void HelloLanding()
        {
            Console.WriteLine("Hello Landing!"); 
        }

    }

  
}
