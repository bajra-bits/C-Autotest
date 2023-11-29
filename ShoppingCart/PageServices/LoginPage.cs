using Newtonsoft.Json.Bson;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using ShoppingCart.PageObjects;
using ShoppingCart.PageServices.core;
using ShoppingCart.Utils;
using System.Linq.Expressions;

namespace ShoppingCart.PageServices
{
    public class LoginPage : NewPage<LandingPage, LoginPageObject>
    {
        LoginPageObject cpo;

        public LoginPage(IWebDriver siteDriver, IWait<IWebDriver> wait, LoginPageObject pageObject) : base(siteDriver, wait, pageObject)
        {
            cpo = (LoginPageObject)pageObject;
        }


        public string PageTitle() => siteDriver.Title;

        public LoginPage NavigateToLogin()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(cpo.logoCssSelector)));
            siteDriver.FindElement(By.LinkText(cpo.LoginLinkText)).Click();
            return this;
        }

        public LandingPage? Login(string email, string password)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(cpo.loginLabelXPathSelector)));
                EnterText(By.CssSelector(cpo.emailCssSelector), email);
                EnterText(By.CssSelector(cpo.passwordCssSelector), password);
                LoginBtnClick();
                var isLoginErr = CheckForLoginError();
                if(!isLoginErr)
                {
                    return new LandingPage(siteDriver, wait, new LandingPageObject());
                }
            }
            catch (Exception ex) {
                // Handle the exception, log it, or take appropriate action
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return null; 
        }

        private Boolean CheckForLoginError()
        {
            try
            {
                var errorText = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(cpo.errorXPathSelector))).Text;
                Assert.That(errorText, Is.EqualTo("Your email or password is incorrect!"));
                Console.WriteLine(String.Format("Error: {0}", errorText));
                return true;

            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
            catch (WebDriverTimeoutException ex)
            {
                return false;
            }
        }

        private void EnterText(By locator, string text)
        {
            ScrollIntoViewAction(siteDriver.FindElement(locator))
           .SendKeys(text);
        }


        private void LoginBtnClick()
        {

            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(cpo.loginBtnCssSelector))).Click();
        }


        public LoginPage CheckPageTitle(string expected)
        {
            expected.CheckPageTitle(PageTitle());
            return this;
        }
    }
}
