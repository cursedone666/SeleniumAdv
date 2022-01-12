using System;
using Xunit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TestProject1.PageObject;

namespace TestProject1
{
    public class UnitTest1 : BaseTest
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = StartDriver("https://edhrec.com/");
            HomePage homePg = new HomePage(driver);
            homePg.clickCards().clickTopCards(); ;


        }


        [Fact]
        public void Test2()
        {
            IWebDriver driver = StartDriver("https://edhrec.com/");
            HomePage homePg = new HomePage(driver);
            homePg.clickCards().saltiestCards(); 
        }

        [Fact]
        public void Test3()
        {
            IWebDriver driver = StartDriver("https://edhrec.com/");
            HomePage homePg = new HomePage(driver);
            homePg.clickCards().ComboCards();
        }
    }
}
