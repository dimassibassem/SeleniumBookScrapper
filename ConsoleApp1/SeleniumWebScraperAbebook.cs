using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SeleniumWebScraperAbebook
    {
        private IWebDriver driver;
        public SeleniumWebScraperAbebook(string isbn)
        {
            try
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.abebooks.com/servlet/SearchResults?kn="+isbn+"&sts=t&cm_sp=SearchF-_-topnav-_-Results");
                var cover = driver.FindElements(By.XPath("//*[@id='listing_1']/div/img"));
                Console.WriteLine(cover[0].GetAttribute("src"));
            }
            catch (Exception e)
            {
                Console.WriteLine("book not found");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}