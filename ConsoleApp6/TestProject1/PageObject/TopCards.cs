using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1.PageObject
{
    class TopCards
    {
        private IWebDriver _driver;
        private By _pastWeek = By.LinkText("Past Week");

        public TopCards(IWebDriver driver)
        {
            _driver = driver;
        }

        public TopCards clickPastWeek()
        {
            _driver.FindElement(_pastWeek).Click();
            return new TopCards(_driver);
        }


    }

}
