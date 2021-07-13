using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Infrastructure.Components
{
    class Topbar:ParentComponent
    {
        private IWebElement HomeElement => ParentElement.FindElement(By.Id("menu-item-41"));
        private IWebElement StartHereElement => ParentElement.FindElement(By.Id("menu-item-4670"));
        private IWebElement SubjectElement => ParentElement.FindElement(By.Id("menu-item-5417"));
        private IWebElement HasoliditSuggestedElement => ParentElement.FindElement(By.Id("menu-item-5418"));
        private IWebElement ContactElement => ParentElement.FindElement(By.Id("menu-item-3064"));
        private IWebElement AllPostsElement => ParentElement.FindElement(By.Id("menu-item-5216"));
        private IWebElement FourmElement => ParentElement.FindElement(By.Id("menu-item-3865"));
        private IWebElement LegalElement => ParentElement.FindElement(By.Id("menu-item-5265"));
        private IWebElement SearchElement => ParentElement.FindElement(By.CssSelector(".typology-actions-button.typology-action-search"));
        private IWebElement MenuElement => ParentElement.FindElement(By.CssSelector(".typology-action-button.typology-action-sidebar"));

        public Topbar(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }

    }
}
