using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AdelinaTest.Helpers
{
    public class Navigation
    {
        public void Navigate(IWebDriver Driver, string url)
        {
            Driver.Navigate().GoToUrl("https://sports.betway.com/en/sports");
            Driver.Manage().Window.Maximize();
        }
    }
}
