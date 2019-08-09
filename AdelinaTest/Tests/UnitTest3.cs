using AdelinaTest.Base;
using NUnit.Framework;

namespace AdelinaTest.Tests
{
    [TestFixture]
    public class UnitTest3 : TestBase
    {
        [Test]
        public void TestMethod1()
        {


            Navigation.Navigate(Driver, "https://sports.betway.com/en/sports");

            
            LoginPage.LoginMethod(Driver);

            Driver.Navigate().Back();
            Driver.Navigate().Forward();
            Driver.Navigate().Refresh();




        }
    }
}
