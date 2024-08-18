using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver_Tasks1_2;

namespace Tests
{
    internal class WebDriverTask2Test : BaseTest
    {
        [Test]
        public void CreateAndVerifyNewPasteTest()
        {
            var pastebinPage = new PastebinPage(driver);
            string code = "git config --global user.name \\\"New Sheriff in Town\\\"\n" +
                          "git reset $(git commit-tree HEAD^{tree} -m \\\"Legacy code\\\")\n" +
                          "git push origin master --force";


            pastebinPage.EnterCode(code);
            pastebinPage.SetSyntaxHighlighting("Bash");
            
            pastebinPage.SetExpiration("10 Minutes");
           
            pastebinPage.EnterName("how to gain dominance among developers");

            pastebinPage.SubmitWithActions();
        }
    }
}
