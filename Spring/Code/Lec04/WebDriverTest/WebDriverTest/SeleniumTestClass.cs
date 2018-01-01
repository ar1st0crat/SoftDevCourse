using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverTest
{
    [TestFixture]
    public class SeleniumTestClass
    {
        private const string Keyword = "C#";

        private IWebDriver _driver;

        [OneTimeSetUp]
        public void Init()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [OneTimeTearDown]
        public void Quit()
        {
            _driver.Quit();
        }

        [Test]
        public void TestSearchResults()
        {
            var searchPage = new SeleniumSearchPage(_driver);
            searchPage.Navigate();
            
            var resultsPage = searchPage.Search(Keyword);

            Assert.That(resultsPage.Links, Does.Contain("Downloads"));
        }
    }
}
