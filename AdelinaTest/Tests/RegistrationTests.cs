using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AdelinaTest
{
    [TestFixture]
    public class RegistrationTests : Basic
    {
        [Test]
        public void TestMethod1()
        {
            GetChromeDriver();

            var registration = Driver.FindElement(By.XPath("/html/body/div/div/div[1]/div/div[3]/div[2]/div/div[5]/div/div/form/input[1]"));
            registration.Click();

            var username = Driver.FindElements(By.Id("UserName"));
            username[2].SendKeys("automation1");

            var password = Driver.FindElements(By.Id("Password"));
            password[2].SendKeys("Testing1");

            var confirmPassword = Driver.FindElements(By.Id("PasswordConfirm"));
            confirmPassword[0].SendKeys("Testing1");


            var email = Driver.FindElements(By.Id("Email"));
            email[2].SendKeys("Testing1");

            var next = Driver.FindElement(By.Id("fieldSet1Submit"));
            next.Click();
            
            


        }
    }
}
