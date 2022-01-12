using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProject1.PageObject
{
    class HomePage
    {
        private IWebDriver _driver;
        private By _navigBarCards = By.Id("navbar-cards");
        private By _sltCards = By.XPath("//div[@id='navbar']/div/div[2]/div/a[2]/span");
        private By _comboCard = By.XPath("//div[@id='navbar']/div/div[2]/div/a[3]/span");
       
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }


        public HomePage clickCards()
        {
            _driver.FindElement(_navigBarCards).Click();


            return this;
        }
        public TopCards clickTopCards()
        {
            _driver.FindElement(_navigBarCards).Click();


            return new TopCards(_driver);
        }

        public SaltiestCards saltiestCards()
        {
            _driver.FindElement(_sltCards).Click();
            return new SaltiestCards(_driver);
        }
        public Combo ComboCards()
        {
            _driver.FindElement(_comboCard).Click();
            return new Combo(_driver);
        }
    }
}
