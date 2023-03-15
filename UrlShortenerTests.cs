using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestURLShortenerWebDriver
{
    public class UrlShortenerTests
    {
        private const string baseUrl = "https://shorturl.softuniqa.repl.co/";
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(baseUrl);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}