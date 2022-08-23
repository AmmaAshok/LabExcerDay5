using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace PageClassLib
{
    public class PageObjectModel
    {
       private IWebDriver _driver;
       [FindsBy(How = How.XPath, Using ="//a[@class='right carousel-control']")]
       private IWebElement RightControl;

        public  PageObjectModel (IWebDriver  driver)
        {
        _driver=driver;
        PageFactory.InitElements(_driver,this); 

        }
    public void login()
    {
        RightControl.Click();
    
    }
    public void close()
    {
        _driver.Quit();
    }
    }
}