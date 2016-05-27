using System;
using TechTalk.SpecFlow;

namespace testGoos.Tests.Feature
{
    [Binding]
    public class HangmanSteps
    {
        [Given(@"have a work ""(.*)""")]
        public void GivenHaveAWork(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"game start")]
        public void WhenGameStart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"tries have show (.*)")]
        public void ThenTriesHaveShow(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"length have show (.*)")]
        public void ThenLengthHaveShow(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"used have show ""(.*)""")]
        public void ThenUsedHaveShow(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"discovered have show ""(.*)""")]
        public void ThenDiscoveredHaveShow(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
