using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using Infrastructure.Components;
using OpenQA.Selenium;


namespace Infrastructure
{
    public class HomePage : Driver
    {
        public Topbar TopBarComponent => new Topbar(ChromeDriver,ChromeDriver.FindElement(By.Id("typology-header")));

        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        public void GoToHomePage (IWebDriver driver)
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["HomePageURL"]);
        }
    }
}
