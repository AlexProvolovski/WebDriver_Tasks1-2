using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Tasks1_2
{
    public class PastebinPage : BasePage
    {
        public PastebinPage(IWebDriver driver) : base(driver) { }


        private IWebElement CodeInput => driver.FindElement(By.Id("postform-text"));
        private IWebElement ExpirationDropdown => driver.FindElement(By.Id("select2-postform-expiration-container"));
        private IWebElement ExpirationOption => driver.FindElement(By.XPath("//li[contains(text(),'10 Minutes')]"));
        private IWebElement SyntaxHighlightingDropdown => driver.FindElement(By.Id("select2-postform-format-container"));
        private IWebElement SyntaxHighlightingOption => driver.FindElement(By.XPath("//li[contains(text(),'Bash')]"));
        private IWebElement NameInput => driver.FindElement(By.Id("postform-name"));
        private IWebElement SubmitButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        public void EnterCode(string code)
        {
            CodeInput.SendKeys(code);
        }

        public void SetExpiration(string expiration)
        {
            ExpirationDropdown.Click();
            ExpirationOption.Click();
        }

        public void SetSyntaxHighlighting(string syntax)
        {
            SyntaxHighlightingDropdown.Click();
            SyntaxHighlightingOption.Click();
        }

        public void EnterName(string name)
        {
            NameInput.SendKeys(name);
        }

        public void SubmitWithActions()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(SubmitButton).Click().Perform();
        }


        #region Part For Check
        //public string GetPageTitle()
        //{
        //    return driver.Title;
        //}

        //public string GetCodeContent()
        //{
        //    return driver.FindElement(By.XPath("//textarea[@class='textarea']")).Text;
        //}
        #endregion
    }
}
