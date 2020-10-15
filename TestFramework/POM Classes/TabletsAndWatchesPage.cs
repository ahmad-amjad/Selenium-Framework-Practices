using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Util;

namespace TestFramework.POM_Classes
{
    public class TabletsAndWatchesPage
    {
        private string PageTitle = "Buy Latest Models | Best Tablet And Gadgets+";

        [FindsBy(How = How.XPath, Using = "//ol[@class='products list items product-items']//a[@class='product-item-link']")]
        private IList<IWebElement> AllTabletNames;

        [FindsBy(How = How.XPath, Using = "//div[@class='product description product-item-description']/p")]
        private IList<IWebElement> AllTabletDesciptions;

        [FindsBy(How = How.XPath, Using = "//ol[@class='products list items product-items']//span[@class='price']")]
        private IList<IWebElement> AllTabletPrices;

        [FindsBy(How = How.XPath, Using = "//ol[@class='products list items product-items']//img")]
        private IList<IWebElement> AllTabletImages;

        public void Goto()
        {
            Pages.ProductNavigation.TabletsAndWatches();
        }

        public bool IsAt()
        {
            return Browser.Title.Equals(PageTitle);
        }

        public void ExportTabletInfoToExcel()
        {
            List<string> tabletNames = AllTabletNames.GetTextOfElements();
            List<string> tabletDescriptions = AllTabletDesciptions.GetTextOfElements();
            List<string> tabletPrices = AllTabletPrices.GetTextOfElements();

            var tabletInfoDictionary = new Dictionary<string, List<string>>() {

                {"TabletName", tabletNames},
                {"TabletDesciption", tabletDescriptions},
                {"TabletPrice", tabletPrices}
            };

            var tabletInfoDataTable = tabletInfoDictionary.GetDataTable();

            ExportToExcel.WriteDataToExcelWorkbook(tabletInfoDataTable);
        }

        public void SaveTabletImagesToDisk()
        {
            List<string> tabletNames = AllTabletNames.GetTextOfElements();
            List<string> allTabletImageLinks = AllTabletImages.GetSpecifiedAttributeOfElements("data-src");

            var tabletImageInfoDictionary = new Dictionary<string, List<string>>() {

                {"TabletName", tabletNames},
                {"TabletImageLink", allTabletImageLinks}
            };

            var tabletImageInfoDataTable = tabletImageInfoDictionary.GetDataTable();

            SaveImages.SaveImagesToDisk(tabletImageInfoDataTable);

        }
    }
}
