using FluentAutomation;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace testGoos.Tests.Feature
{
    [Binding]
    public class HangmanSteps : FluentTest
    {
        private ChromeDriver Driver
        {
            get
            {
                return (ChromeDriver)ScenarioContext.Current["DRIVER"];
            }
        }

        [Given(@"have a work ""(.*)""")]
        public void GivenHaveAWork(string p0)
        {
        }
        
        [When(@"game start")]
        public void WhenGameStart()
        {
            Driver.Navigate().GoToUrl("http://localhost:2938/Hangman/Index");
        }
        
        [Then(@"tries have show (.*)")]
        public void ThenTriesHaveShow(int tries)
        {
            
            Assert.IsTrue(Driver.PageSource.Contains("Tries :" + tries));
        }
        
        [Then(@"length have show (.*)")]
        public void ThenLengthHaveShow(int length)
        {
            Assert.IsTrue(Driver.PageSource.Contains("Length :" + length));
        }
        
        [Then(@"used have show ""(.*)""")]
        public void ThenUsedHaveShow(string used)
        {
            Assert.IsTrue(Driver.PageSource.Contains("Used :" + used));
        }
        
        [Then(@"discovered have show ""(.*)""")]
        public void ThenDiscoveredHaveShow(string discovered)
        {
            Assert.IsTrue(Driver.PageSource.Contains("Discovered :" + discovered));
        }
    }
}
