using System;
using NUnit.Framework;
using System.Collections.Generic;
using TestFramework.TestingData;
using OpenQA.Selenium;
using System.Linq;

namespace TestFramework
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SearchTest : InitClass
    {
        private IWebDriver driver;
        private SearchResultsPage page;

        [OneTimeSetUp]
        public void Init()
        {
            driver = WebDriver.GetBrowser(Data.browser1);
            page = new SearchResultsPage(driver);
        }

        [Test, TestCaseSource("journalChoice")]
        public void NUnitTestSearch(string name)
        {
            Journal journal = dictionary[name];
            page.NavigateHere($"{journal.Name}/");
            string search = testdata.List.Where(e => e.Name == name).Select(e => e.Search.Text).Last();

            page.SearchEnter(search);
            page.SearchClick(search);

            Assert.True(page.ResultsElement != null);
        }

        [OneTimeTearDown]
        public void Clear()
        {
            page.Quit();
        }
    }
}
