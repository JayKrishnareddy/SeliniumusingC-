using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace SeleniumUsingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables for web drivers
            IWebDriver driver;
            WebDriverWait wait;

            
            using (driver = new ChromeDriver())
            {
                //Assigning timeout
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

                // Navigating to Price-Card URl

                driver.Navigate().GoToUrl(@"https://test-pricecard.metrixlab.com/");
                wait.Until<bool>((d) => { return d.Title.Contains("Price-Calculator"); });
                IWebElement textboxusername = driver.FindElement(By.Id("exampleInputEmail1"));
                IWebElement textboxpassword = driver.FindElement(By.Id("exampleInputPassword1"));
                //searchbox.Click();

                //search for selenium c#
                // Login Mechanism 
                textboxusername.SendKeys("jayakrishna.majji@us.metrixlab.com");
                textboxpassword.SendKeys("Jay@10125");
                IWebElement btnsignin = driver.FindElement(By.Id("submit"));
                btnsignin.Submit();

                Thread.Sleep(12000);
            }
        }
    }
}
