﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using ShoppingCart.PageObjects;
using ShoppingCart.PageServices.core;
using ShoppingCart.Utils;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace ShoppingCart.PageServices
{
    public class RegisterPage : NewPage<RegisterPageObject>
    {
        public RegisterPageObject cpo;


        public RegisterPage(IWebDriver siteDriver, IWait<IWebDriver> wait, RegisterPageObject pageObject) : base(siteDriver, wait, pageObject)
        {
            cpo = (RegisterPageObject)pageObject;
        }


        public RegisterPage CheckPageTitle(string expected)
        {
            expected.CheckPageTitle(siteDriver.Title);
            return this;
        }
        public RegisterPage NavigateToSignup()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(cpo.logoCssSelector)));
            siteDriver.FindElement(By.LinkText(cpo.registerLinkText)).Click();
            return this;
        }

        public LandingPage Register()
        {
            WaitForElementIsVisible(By.XPath(cpo.registerTitleXPathSelector));
            EnterText(By.CssSelector(cpo.usernameCssSelector), "supertest@getnada.com");
            EnterText(By.CssSelector(cpo.emailCssSelector), "testagain123@getnada.com");

            // Click Signup button
            ButtonClickTrigger(By.CssSelector(cpo.buttonCssSelector));
            var duplicateExists = CheckDuplicateEmailExists();

            if (!duplicateExists)
            {
                WaitForElementIsVisible(By.XPath(cpo.accountsTitleXPathSelector));
                siteDriver.FindElements(By.CssSelector(cpo.radioCssSelector));
            }

            EnterRadioTitle(1);
            SelectOptionByVisibleText(By.CssSelector(cpo.days), "12");
            SelectOptionByVisibleText(By.CssSelector(cpo.months), "May");
            SelectOptionByVisibleText(By.CssSelector(cpo.years), "1998");
            EnterText(By.CssSelector(cpo.firstName), "supertest");
            EnterText(By.CssSelector(cpo.lastName), "supertest");
            EnterText(By.CssSelector(cpo.company), "supertest");
            EnterText(By.CssSelector(cpo.address), "supertest");
            EnterText(By.CssSelector(cpo.address2), "supertest");
            SelectOptionByVisibleText(By.CssSelector(cpo.country), "India");
            EnterText(By.CssSelector(cpo.state), "supertest");
            EnterText(By.CssSelector(cpo.city), "supertest");
            EnterText(By.CssSelector(cpo.zipCode), "supertest");
            EnterText(By.CssSelector(cpo.mobileNumber), "supertest");

            ButtonClickTrigger(By.CssSelector(cpo.createAccountBtnCssLocator)); 
            ButtonClickTrigger(By.CssSelector(cpo.continueBtnCssLocator));

            return new LandingPage(siteDriver, wait, new LandingPageObject()); 
        }


        private void SelectOptionByVisibleText(By selector, string visibleText)
        {
            IWebElement element = siteDriver.FindElement(selector);
            SelectElement selectEl = new SelectElement(element);
            selectEl.SelectByText(visibleText);
        }

       
        private Boolean CheckDuplicateEmailExists()
        {
            try
            {
                var emailExists = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(cpo.emailExistsXPathSelector)));
                Assert.That(emailExists.Text, Is.EqualTo("Email Address already exist!"));
                Console.WriteLine("******** DUPLICATE EMAIL EXISTS ************");
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

        private void EnterText(By locator, string value)
        {
            siteDriver.FindElement(locator).SendKeys(value);

        }

        private void WaitForElementIsVisible(By locator)
        {

            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }



        private void ButtonClickTrigger(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click(); 
        }

       

        private void EnterRadioTitle(int index)
        {
            if(index > 2)
            {
                throw new Exception(String.Format("Invalid index {0}", index));
            } 
            _ = (IList<WebElement>)siteDriver.FindElements(By.CssSelector(cpo.radioCssSelector))[index];
        }

    }
}
