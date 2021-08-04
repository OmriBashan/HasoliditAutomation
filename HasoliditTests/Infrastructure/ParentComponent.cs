using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Infrastructure
{
   public class ParentComponent : Driver
    {
        protected IWebElement ParentElement { get; }
        public ParentComponent(IWebDriver driver, IWebElement element) : base(driver)
        {
            ParentElement = element;
        }
    }
}
