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

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

        [Test]
        public void Test_CheckTitle()
        {
            var pageTitle = driver.Title;
            Assert.That("URL Shortener", Is.EqualTo(pageTitle));
        }

        [Test]
        public void Test_CheckShortUrlsPage()
        {
            var shortUrl = driver.FindElement(By.LinkText("Short URLs"));
            shortUrl.Click();
            var shortUrlsTitle = driver.FindElement(By.CssSelector("main > h1")).Text;
            Assert.That("Short URLs", Is.EqualTo(shortUrlsTitle));

            var tableCells = driver.FindElements(By.CssSelector("tr > td"));
            Assert.That(tableCells[0].Text, Is.EqualTo("https://nakov.com"));
            Assert.That(tableCells[1].Text, Is.EqualTo("http://shorturl.softuniqa.repl.co/go/nak"));
        }
    }
}