using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class GoogleSteps
    {
        [Given(@"I am on google")]
        public void GivenIAmOnGoogle()
        {
            Console.WriteLine("DDDD");
        }
        
        [When(@"I search ""(.*)""")]
        public void WhenISearch(string p0)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the result")]
        public void ThenIShouldSeeTheResult()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
