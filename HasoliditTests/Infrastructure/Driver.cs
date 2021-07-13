using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure
{
    class Driver
    {
        protected IWebDriver ChromeDriver { get; }

        public Driver(IWebDriver driver)
        {
            ChromeDriver = driver;
        }
    }
}
