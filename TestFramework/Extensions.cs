using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Extensions
    {
        public static void Hover(this IWebElement element)
        {
            Actions builder = new Actions(Browser.Driver);
            builder.MoveToElement(element).Build().Perform();
        }

        public static List<string> GetTextOfElements(this IList<IWebElement> elementList){
            List<string> elementsTextList = new List<string>();
            foreach (IWebElement element in elementList) {
                elementsTextList.Add(element.Text);
            }
            return elementsTextList;
        }

        public static List<string> GetSpecifiedAttributeOfElements(this IList<IWebElement> elementList, string attribute) {
            List<string> elementsAttributeList = new List<string>();
            foreach (IWebElement element in elementList)
            {
                elementsAttributeList.Add(element.GetAttribute(attribute));
            }
            return elementsAttributeList;
        }
    }
}
