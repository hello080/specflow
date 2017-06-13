using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace BDD_SPECFLOW.Steps

{
    [Binding]
    public class TC_01Steps
    {
        IWebDriver driver;

        [Given(@"I am on LiveGuru site")]
        public void GivenIAmOnLiveGuruSite()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://live.guru99.com/");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
        }

        [Given(@"I quit browser")]
        public void IQuitBrowser(){
            driver.Quit();
        }
    }
}
