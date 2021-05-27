using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var dropdown = By.CssSelector("#cm-dropdown1");

            driver.Navigate().GoToUrl("https://academymortgage.com/");
            driver.Manage().Window.Maximize();

            driver.FindElement(dropdown).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText("Who We Are")));
            driver.FindElement(By.LinkText("Who We Are")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(dropdown));
            driver.FindElement(dropdown).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText("What Sets Us Apart")));
            driver.FindElement(By.LinkText("What Sets Us Apart")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(dropdown));
            driver.FindElement(dropdown).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText("How We Measure Success")));
            driver.FindElement(By.LinkText("How We Measure Success")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(dropdown));
            driver.FindElement(dropdown).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText("Where We Began")));
            driver.FindElement(By.LinkText("Where We Began")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(dropdown));
            driver.FindElement(dropdown).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText("Contact Us")));
            driver.FindElement(By.LinkText("Contact Us")).Click();
            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
