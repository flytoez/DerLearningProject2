using AdelinaTest.Base;
using NUnit.Framework;


namespace AdelinaTest.Tests 
{
    public class BettingTests : TestBase
    {

        [Test]
        public void Cashout()
        {

            Navigation.Navigate(Driver, "https://sports.betway.com/en/sports");

            LoginPage.LoginMethod(Driver);
            
            Inplay.AddBetsIntoBetslip(Driver);
        
            Inplay.PlaceBet(Driver);

            Inplay.Cashout(Driver);
            
        }


       


    }
}
