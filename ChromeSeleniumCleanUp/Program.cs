using System;
using System.Diagnostics;

namespace ChromeSeleniumCleanUp
{
    class Program
    {
        static void Main(string[] args)
        {
            var chromedrivers = Process.GetProcessesByName("chromedriver");
            var consoleHosts = Process.GetProcessesByName("chrome.exe");
            foreach (var process in chromedrivers)
            {
                process.Kill();
            }

            foreach (var process in consoleHosts)
            {
                process.Kill();
            }
        }
        
    }
}
