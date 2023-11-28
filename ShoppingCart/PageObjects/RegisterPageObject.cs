using OpenQA.Selenium;
using ShoppingCart.PageObjects.core;

namespace ShoppingCart.PageObjects
{
    public class RegisterPageObject : PageObject<RegisterPageObject>
    {
        public string registerLinkText = "Signup / Login";
        public string logoCssSelector = "img[src*='logo.png']";
        public string registerTitleXPathSelector = "//*[contains(text(), 'New User Signup')]";
        public string usernameCssSelector = "input[data-qa='signup-name']";
        public string emailCssSelector = "input[data-qa='signup-email']";
        public string passwordCssSelector = "input[data-qa='password']";
        public string buttonCssSelector = "button[data-qa='signup-button']";
        public string accountsTitleXPathSelector = "//*[contains(text(), 'Enter Account Information')]";
        public string radioCssSelector = "input[type='radio']";
        public string emailExistsXPathSelector = "//*[contains(text(), 'Email Address already exist!')]";


        public string radioMr = "div#uniform-id_gender1";
        public string radioMrs = "div#uniform-id_gender2";
        public string radio = "div.radio input[type='radio']"; 

        public string days = "select[data-qa='days']";
        public string months = "select[data-qa='months']";
        public string years = "select[data-qa='years']";

        public string newsletter = "input#newsletter";
        public string specialOffers = "input[name='optin']";

        /* ADDRESS INFO */
        public string firstName = "input[data-qa='first_name']";
        public string lastName = "input[data-qa='last_name']";
        public string company = "input[data-qa='company']";
        public string country = "select[data-qa='country']";
        public string address = "input[data-qa='address']";
        public string address2 = "input[data-qa='address2']";
        public string state = "input[data-qa='state']";
        public string city = "input[data-qa='city']";
        public string zipCode = "input[data-qa='zipcode']";
        public string mobileNumber = "input[data-qa='mobile_number']";


        public string createAccountBtnCssLocator = "button[data-qa='create-account']";
        public string continueBtnCssLocator = "a[data-qa='continue-button']";
    }
}
