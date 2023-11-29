﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using ShoppingCart.PageObjects.core;
using ShoppingCart.Utils;

namespace ShoppingCart.PageServices.core
{
    public class NewPage<T, U>
    {
        public IWebDriver siteDriver;
        public IWait<IWebDriver> wait;
        public PageObject<U> pageObject;
        public Actions actions;
        public IJavaScriptExecutor jsExecutor;

        public NewPage(IWebDriver siteDriver, IWait<IWebDriver> wait, PageObject<U> pageObject)
        {
            this.siteDriver = siteDriver;
            this.wait = wait;
            this.pageObject = pageObject;
            this.actions = new Actions(siteDriver);
            this.jsExecutor = (IJavaScriptExecutor)siteDriver;
        }



        protected void ScrollIntoView(int x, int y)
        {
            jsExecutor.ExecuteScript(String.Format("window.scrollBy({0}, {1});", x, y));
        }


        protected void ScrollToBottom()
        {
            jsExecutor.ExecuteScript("window.scrollTo({ top: document.body.scrollHeight, behavior: 'smooth' });");

        }



        protected IWebElement ScrollIntoViewAction(IWebElement element)
        {
            var actions = new Actions(siteDriver);
            actions.MoveToElement(element)
                .Perform();
            return element;
        }


        protected void HoverElement(IWebElement element)
        {
            actions.MoveToElement(element)
                .Perform();
        }


        protected void ElementIsVisisble(By locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator)); 
        } 


        protected void BtnClick(By locator)
        {

            wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

        public void Logout()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(pageObject.logoutLinkText))).Click();
        }


        public void DeleteAccount()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(pageObject.deleteAccountLinkText))).Click();
        }


        public void GoToCart()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText(pageObject.cartLinkText))).Click();
        }




        /*  public T? CheckPageTitle(string expected)
          {
              expected.CheckPageTitle(siteDriver.Title);
              return default;
          }*/

    }
}
