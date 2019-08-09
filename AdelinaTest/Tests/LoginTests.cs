using AdelinaTest.Base;
using AdelinaTest.Helpers;
using NUnit.Framework;

namespace AdelinaTest.Tests
{
    public class LoginTests : TestBase
    {
        
        [Test]
        public void TestMethod1()
        {
           Navigation.Navigate(Driver,"https://sports.betway.com/en/sports");

           LoginPage.LoginMethod(Driver);


        }

    }
}
