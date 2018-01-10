using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumSiteSpecs
{
    [Binding]
    public class SearchCSharpFeatureSteps
    {
        private IWebDriver _driver;

        private SeleniumSearchPage _searchPage;
        private SearchResultsPage _resultsPage;

        [BeforeScenario]
        public void Init()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [AfterScenario]
        public void Quit()
        {
            _driver.Quit();
        }

        [Given(@"I have opened Selenium search page")]
        public void GivenIHaveOpenedSeleniumSearchPage()
        {
            _searchPage = new SeleniumSearchPage(_driver);
            _searchPage.Navigate();
        }

        [Given(@"I have entered (.*)")]
        public void GivenIHaveEntered(string query)
        {
            _searchPage.EnterSearchQuery(query);
        }
        
        [When(@"I press search button")]
        public void WhenIPressSearchButton()
        {
            _resultsPage = _searchPage.ClickSearch();
        }
        
        [Then(@"the search results contain (.*)")]
        public void ThenTheSearchResultsContain(string link)
        {
            Assert.That(_resultsPage.Links, Does.Contain(link));
        }
    }
}
