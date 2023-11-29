using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

    }

  
}
