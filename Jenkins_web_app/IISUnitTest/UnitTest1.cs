using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace IISUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        InternetExplorerOptions options = new InternetExplorerOptions();

        IWebDriver IEDriver = null;
        [TestInitialize]
        public void initialize()
        {
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            string path = @"C:\Users\nirotpalm626\Documents\GitHub\Web_app\Jenkins_web_app\IISUnitTest";
            IEDriver = new InternetExplorerDriver(path, options);
            IEDriver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));

        }
        [TestMethod]
        public void TestMethod1()
        {
            IEDriver.Navigate().GoToUrl("http://localhost/Jenkins_web_app/");
            IEDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            IEDriver.Manage().Window.Maximize();
            IWebElement verifyText = IEDriver.FindElement(By.CssSelector("body > div.container.body-content > div.jumbotron > p.lead"));
            if (verifyText.GetAttribute("innerHTML").Trim().Equals("ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript."))
            {
                Console.WriteLine("Text matched");
            }
        }
        [TestCleanup]
        public void Testcleanup()
        {
            IEDriver.Close();
        }
    }
}
