using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace testGoos.Tests.Feature
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
            ScenarioContext.Current["DRIVER"] = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            ((ChromeDriver)ScenarioContext.Current["DRIVER"]).Quit();
        }
    }
}
