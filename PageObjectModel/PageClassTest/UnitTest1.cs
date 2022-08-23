using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace PageClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            IWebDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl("http://webdriveruniversity.com/");
            PageClassLib.IndexPage PageObjectModel=new PageClassLib.IndexPage(driver);
            PageObjectModel.login();
            Thread.Sleep(5000);
            
        }
        [TestMethod]
        public void TestMethod2()
        { 
            IWebDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.webdriveruniversity.com/Page-Object-Model/index.html");
            PageClassLib.PageObjectModel PageObjectModel=new PageClassLib.PageObjectModel(driver);
            PageObjectModel.login();
            Thread.Sleep(5000);
            
        }
    }
}

