using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.POM_Classes;

namespace TestFramework.POM_Classes
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static ProductNavigationMenu ProductNavigation
        {
            get { return GetPage<ProductNavigationMenu>(); }
        }

        public static TabletsAndWatchesPage TabletsAndWatches
        {
            get { return GetPage<TabletsAndWatchesPage>(); }
        }
    }
}
