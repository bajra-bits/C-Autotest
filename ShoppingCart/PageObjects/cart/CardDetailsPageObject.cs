using ShoppingCart.PageObjects.core;

namespace ShoppingCart.PageObjects.cart
{
    public class CardDetailsPageObject : PageObject<CardDetailsPageObject>
    {
        public string CheckoutLinkText = "Proceed To Checkout";
        public string nameOnCardCssSelector = "input[data-qa='name-on-card']"; 
        public string cardNumberCssSelector = "input[data-qa='card-number']"; 
        public string cvcCssSelector = "input[data-qa='cvc']"; 
        public string expiryMonthCssSelector = "input[data-qa='expiry-month']"; 
        public string expiryYearCssSelector = "input[data-qa='expiry-year']"; 
        public string payBtnCssSelector = "button[data-qa='pay-button']"; 

    }
}
