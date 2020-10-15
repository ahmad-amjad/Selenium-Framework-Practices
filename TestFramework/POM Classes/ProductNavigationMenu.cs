using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.POM_Classes
{
    public class ProductNavigationMenu
    {

        [FindsBy(How = How.XPath, Using = "//a[@title='Products']")]
        private IWebElement ProductLink;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Tablets/Watches']")]
        private IWebElement TabletsAndWatchesLink;

        public void TabletsAndWatches() {
            ProductLink.Hover();
            TabletsAndWatchesLink.Click();
        }
    }
}
