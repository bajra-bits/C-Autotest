using ShoppingCart.PageObjects.core;

namespace ShoppingCart.PageObjects.cart
{
    public class OrderConfirmPageObject : PageObject<OrderConfirmPageObject>
    {
        public string OrderConfirmXPathSelector = "//*[contains(text(), 'Congratulations')]";
        public string ContinueOrderLinkText = "Continue"; 
        public string DownloadInvoiceLinkText = "Download Invoice"; 
    }
}
