using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriverBotApplication
{
    // Простой бот, который проверяет, что адрес donnu.ru 
    // присутствует в первых результатах по запросу "donnu" 
    // поисковиков: сначала Google, затем Yandex

    class Program
    {
        static readonly IWebDriver _driver = new ChromeDriver();

        static void Main()
        {
            const string addressToAppear = "donnu.ru";
            
            _driver.Navigate().GoToUrl(@"http://www.google.com");

            IWebElement search = _driver.FindElement(By.Name("q"));

            search.SendKeys("donnu");
            System.Threading.Thread.Sleep(250);         // for visualization
            search.SendKeys(Keys.Enter);

            // Not a good way of waiting
            // System.Threading.Thread.Sleep(1500);     // for waiting

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            wait.Until(d => d.FindElement(By.CssSelector("div.r > a")));

            var entries = _driver.FindElements(By.CssSelector("div.r > a"));

            if (entries.Any(entry => entry.GetAttribute("href").Contains(addressToAppear)))
            {
                Console.WriteLine("Google Test OK!");
            }

            _driver.Navigate().GoToUrl(@"http://ya.ru");

            wait.Until(d => d.FindElement(By.Id("text")));

            search = _driver.FindElement(By.Id("text"));
            search.SendKeys("donnu");
            System.Threading.Thread.Sleep(250);     // for visualization
            search.SendKeys(Keys.Enter);

            wait.Until(d => d.FindElement(By.ClassName("serp-list")));

            try
            {
                entries = _driver.FindElements(By.XPath("//a[contains(@class, 'link')]/b"));

                if (entries.Any(entry => entry.Text.Contains(addressToAppear)))
                {
                    Console.WriteLine("Yandex Test OK!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + "\n" + ex.Message);
            }
            finally
            {
                _driver.Quit();
            }
        }
    }
}
