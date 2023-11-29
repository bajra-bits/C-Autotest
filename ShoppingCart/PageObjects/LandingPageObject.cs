using ShoppingCart.PageObjects.core;

namespace ShoppingCart.PageObjects
{
    public class LandingPageObject: PageObject<LandingPageObject>
    {
        public string addToCartModal = "div.modal-content";
        public string productCssSelector = "div[class*='productinfo']";
        //public string addToCartSelector = "a[class*='add-to-cart']";
        public string addToCartSelector = "div.product-overlay a[data-product-id='{0}']";
        public string continueShoppingBtnXPathLocator = "//button[contains(text(), 'Shopping')]"; 

        public LandingPageObject() { }
    }
}
