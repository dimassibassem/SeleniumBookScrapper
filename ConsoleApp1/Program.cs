using ConsoleTables;
using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // var bookFinder = new SeleniumWebScraperBookFinder("9782200623074");
            // Thread.Sleep(5000);
            // var abebook = new SeleniumWebScraperAbebook("9782200623074");
            // Thread.Sleep(5000);
            // var Cpu = new SeleniumWebScraperCpu("978-9973-37-618-3");
            // Thread.Sleep(5000);
            // var amazon = new SeleniumWebScraperAmazon("9781609882617");
            Thread.Sleep(5000);
            var alManhal = new SeleniumWebScraperAlManhal("9789957118075");
        }

        
    }
}