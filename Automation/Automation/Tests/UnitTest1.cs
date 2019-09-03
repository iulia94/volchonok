using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class UnitTest1
    {
        private SeleniumActions selenium;
        [TestInitialize]
        public void Open() {
            selenium = new SeleniumActions(Browsers.InternetExplorer);
        }
        [TestMethod]
        public void TestMethod1()
        {           
            selenium.Navigate("https://wikipedia.org");
            selenium.Input(".//input[@id='searchInput']","Moldova");
            selenium.SelectValue(".//select[@id='searchLanguage']","en");
            selenium.Click(".//button[@type='submit']");
            string actualResult = selenium.GetText(".//h1[@id='firstHeading']");
            string expectedResult = "Moldova";
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCleanup]
        public void Close() {
            selenium.Close();
        }

    }
}
