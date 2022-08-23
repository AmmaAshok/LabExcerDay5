using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace PageClassLib
{
    public class IndexPage
    {
        private IWebDriver _driver;
        [FindsBy(How = How.XPath, Using = "//a[@href='Page-Object-Model/index.html']//h1['PAGE OBJECT MODEL']")]
        private IWebElement HyperLink;
    
        public  IndexPage (IWebDriver  driver)
        {
        _driver=driver;
        PageFactory.InitElements(_driver,this); 

        }
    public void login()
    {
        HyperLink.Click();
    
    }
    public void close()
    {
        _driver.Quit();
    }
}
}