using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class SearchResultsPage : PageObject
    {
        private string resultsLocator = $"//div[contains(@id,'results')]";

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement ResultsElement
        {
            get { return Driver.FindElement(By.XPath(resultsLocator)); }
        }
    }
}
