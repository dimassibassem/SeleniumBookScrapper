using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    public class SeleniumWebScraperCpu
    {
        private IWebDriver driver;

        public SeleniumWebScraperCpu(string isbn)
        {
            try
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.cpu.rnu.tn/index.php/shop/");
                var input = driver.FindElement(
                    By.XPath("//*[@id='woocommerce_product_search-2']/div/form/p[1]/input[1]"));
                input.SendKeys(isbn);
                System.Threading.Thread.Sleep(2000);
                var button =
                    driver.FindElement(By.XPath("//*[@id='woocommerce_product_search-2']/div/form/p[2]/button"));
                button.Click();
                // todo: need some fixes here
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("here");
                var cover = driver.FindElement(By.ClassName("attachment-shop_single"));
                var ISBN = driver.FindElement(By.XPath("//div[1]/div[2]/div[2]/div/p[3]"));
                var title = driver.FindElement(By.XPath("//div[1]/div[2]/div[1]/h1"));
                var editor = driver.FindElement(By.XPath("//div[1]/div[2]/div[2]/div/p/strong"));
                Console.WriteLine(cover.GetAttribute("src"));
                Console.WriteLine(editor.Text);
                Console.WriteLine(ISBN.Text);
                Console.WriteLine(title.Text);

                driver.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                driver.Quit();
            }
        }
    }
}