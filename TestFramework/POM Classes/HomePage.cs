using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.POM_Classes
{
    public class HomePage
    {
        private string PageTitle = "Galaxy Pakistan's Leading Web Store - Buy Online Laptops - Desktop - Graphic Card - Tablets - iPad - iPhone - Gaming Notebook - Accessories - Smartphone";

        public bool IsAt()
        {
            return Browser.Title.Equals(PageTitle);
        }
    }
}
