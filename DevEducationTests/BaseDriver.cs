using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace DevEducationTests
{
    public class BaseDriver
    {
        public IWebDriver driver;

        


        [SetUp]
        public void StarBrowser()
        {
            driver = new ChromeDriver("D:\\");
            driver.Manage().Window.Maximize();
        }



        [TearDown]
        public void CloseBrowser()
        {
            //Thread.Sleep(5000); Таймер закрытия браузера

            driver.Close();
        }
    }
}
