using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AdelinaTest.Page
{
    public class Inplay
    {

        public void AddBetsIntoBetslip(IWebDriver Driver)
        {
            var inPlay = Driver.FindElement(By.CssSelector("div.icon-channel-inplay"));
            inPlay.Click();

            var odd = Driver.FindElement(By.CssSelector("*[collectionitem=\"453869212\"]"));
            odd.Click();

           
        }

        public void PlaceBet(IWebDriver Driver)
        {
            var stake = Driver.FindElement(By.CssSelector("div.stakeInputContainer input"));
            stake.SendKeys("2");

            var placeBet = Driver.FindElement(By.CssSelector("span.content.innerText"));
            placeBet.Click();

            Thread.Sleep(8000);

            var successfullMessage = Driver.FindElement(By.CssSelector("div.betsSuccessItemText"));
            Assert.IsTrue(successfullMessage.Displayed);


        }

        public void Cashout(IWebDriver Driver)
        {
            IWebElement cashoutButton = Driver.FindElement(By.CssSelector("div.cashoutText"));

            if (cashoutButton.Text.Equals("Cash Out"))
            {
                Console.WriteLine("Cash Out");
                cashoutButton.Click();

                IWebElement confirmElement = Driver.FindElement(By.CssSelector("div.cashoutText"));
                if (confirmElement.Text.Contains("Confirm"))
                {
                    confirmElement.Click();
                }
                
            }
            else
            { 
                Console.WriteLine("Cashout unavailable");
            }
        }
    } 
}
