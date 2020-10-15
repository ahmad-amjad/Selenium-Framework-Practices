using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Browser
    {
        private static string baseUrl = "https://www.galaxy.pk/";
        private static IWebDriver webDriver = new EdgeDriver(new EdgeOptions
        {
            PageLoadStrategy = PageLoadStrategy.Normal
        });
        public static void Initialize()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Goto("");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static IWebDriver Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
