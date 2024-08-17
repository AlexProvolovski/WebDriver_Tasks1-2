using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver_Tasks1_2;

namespace Tests
{
    internal class WebDriverTask1Test : BaseTest
    {
        [Test]
        public void CreateNewPasteTest()
        {
            var pastebinPage = new PastebinPage(driver);

            pastebinPage.EnterCode("Hello from WebDriver");
            pastebinPage.SetExpiration("10 Minutes");
            pastebinPage.EnterName("helloweb");
            pastebinPage.Submit();
        }
    }
}
