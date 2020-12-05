using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    


    static void Main()
    {
        string url = "google.com";


        /* ---------  ---------  Navigate to Blazor7 --------- */
        driver.Navigate().GoToUrl("url");
        /* ---------  --------- Delay 7sec --------- */
        Thread.Sleep(5000);

        /* ---------  --------- Find and click one of the Jobs --------- */
        /* ---------  --------- Delay 5ec*/
        driver.FindElement(By.Id("b7-jobNumber-1")).Click();
        Thread.Sleep(30000);

        driver.Quit();

    }
}
