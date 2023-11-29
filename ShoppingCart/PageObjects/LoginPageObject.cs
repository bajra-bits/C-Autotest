using ShoppingCart.PageObjects.core;

namespace ShoppingCart.PageObjects
{
    public class LoginPageObject: PageObject<LoginPageObject>
    {
        public string LoginLinkText = "Signup / Login";
        public string logoCssSelector = "img[src*='logo.png']";
        public string loginLabelXPathSelector = "//*[contains(text(), 'Login to your account')]";
        public string emailCssSelector = "input[data-qa='login-email'"; 
        public string passwordCssSelector = "input[data-qa='login-password'"; 
        public string loginBtnCssSelector = "button[data-qa='login-button'";
        public string errorXPathSelector = "//*[contains(text(), 'Your email or password is incorrect!')]"; 

    }
}
