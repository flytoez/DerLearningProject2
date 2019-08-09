using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AdelinaTest.Page
{
    public class Login
    {

        public void LoginMethod(IWebDriver driver)
        {
            var username = driver.FindElement(By.CssSelector("div.usernameInput input"));
            username.SendKeys("ludo197");

            var password = driver.FindElement(By.CssSelector("div.passwordInput input"));
            password.SendKeys(("password1234$"));

            var login = driver.FindElement(By.CssSelector("div.submitButton span"));
            login.Click();
        }
    }
}
