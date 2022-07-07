using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    public class SeleniumWebScraperBookFinder
    {
        private IWebDriver driver;

        public SeleniumWebScraperBookFinder(string isbn)
        {
            try
            {
                driver = new ChromeDriver();

                driver.Navigate().GoToUrl("https://www.bookfinder.com/search/?author=&title=&lang=en&isbn=" + isbn +
                                          "&new_used=*&destination=tn&currency=USD&mode=basic&st=sr&ac=qr");
                var cover = driver.FindElements(By.XPath("//*[@id='coverImage']"));
                Console.WriteLine(cover[0].GetAttribute("src"));
                driver.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine("Book not found");
                driver.Quit();
            }
        }
    }
}