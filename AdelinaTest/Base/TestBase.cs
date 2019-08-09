using System.IO;
using System.Reflection;
using AdelinaTest.Helpers;
using AdelinaTest.Page;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AdelinaTest.Base
{
    public class TestBase
    {
        public OpenQA.Selenium.IWebDriver Driver = null;
        public Login LoginPage;
        public Navigation Navigation;
        public Inplay Inplay;



        [SetUp]
        public void GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Driver = new ChromeDriver(outPutDirectory);

            // Setup Page Objects
            SetUpObject();
        }

        private void SetUpObject()
        {
            LoginPage = new Login();
            Navigation = new Navigation();
            Inplay = new Inplay();

        }

        [TearDown]
        public void TestTearDown()
        {
            Driver.Close();
            Driver.Quit();
        }



        

        
    }
}