using OpenQA.Selenium;
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

        public void EnterName(string name)
        {
            NameInput.SendKeys(name);
        }

        public void Submit()
        {
            SubmitButton.Click();
        }

    }
}
