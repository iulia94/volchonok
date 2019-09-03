using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation
{
    public class SeleniumActions
    {
        private IWebDriver driver;
        public SeleniumActions(Browsers browser) {
            string filePath = Environment.CurrentDirectory + "\\Drivers\\";
            switch (browser) {
                case Browsers.Firefox:
                    var firefoxOptions = new FirefoxOptions();
                    firefoxOptions.BrowserExecutableLocation = "C:\\Program Files\\Mozilla Firefox\\firefox.exe";
                    driver = new FirefoxDriver(filePath, firefoxOptions);
                    break;
                case Browsers.InternetExplorer:
                    var ieOptions = new InternetExplorerOptions();
                    ieOptions.IgnoreZoomLevel = true;
                    driver = new InternetExplorerDriver(filePath,ieOptions);
                    break;
                default:
                    driver = new ChromeDriver(filePath);
                    break;
            }
        }
        public void Navigate(string url) {
            driver.Navigate().GoToUrl(url);
        }
        public void Input(string xPath, string text) {
            var element = driver.FindElement(By.XPath(xPath));
            element.SendKeys(text);
        }
        public void Click(string xPath) {
            var element = driver.FindElement(By.XPath(xPath));
            element.Click();
        }
        public void SelectValue(string xPath,string value) {
            var element = driver.FindElement(By.XPath(xPath));
            var selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }
        public string GetText(string xPath) {
            var element = driver.FindElement(By.XPath(xPath));
            string text = element.Text;
            return text;
        }
        public void Close() {
            driver.Quit();
        }
    }
}
