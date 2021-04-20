using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WebDriverTest
{
    public class SeleniumSearchPage
    {
        private const string Url = @"http://www.seleniumhq.org/";

        private const string SearchQueryFieldId = "search";
        private const string SearchButtonId = "submit";

        private readonly IWebDriver _driver;

        [FindsBy(How = How.Name, Using = SearchQueryFieldId)]
        public IWebElement SearchQueryField;

        [FindsBy(How = How.Id, Using = SearchButtonId)]
        public IWebElement SearchButton;
        
        public SeleniumSearchPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl(Url);
        }

        public SearchResultsPage Search(string keyword)
        {
            SearchQueryField.SendKeys(keyword);
            SearchButton.Click();
            
            return new SearchResultsPage(_driver);
        }
    }

    public class SearchResultsPage
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='gs-title']")]
        public IList<IWebElement> LinkElements;

        public SearchResultsPage(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(p => p.FindElement(By.Id("cse-body")));

            PageFactory.InitElements(driver, this);
        }

        public List<string> Links => LinkElements.Select(l => l.Text).ToList();
    }
}
