using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace Specflow.Steps
{
    [Binding]
    public class AppbuilderServiceSteps
    {
        string content;
        IRestResponse response;
        [Given(@"I get appbuilder authentication service endpoint")]
        public void GivenIGetAppbuilderAuthenticationServiceEndpoint()
        {
            var client = new RestClient("https://dev.supplychainsoft.com/scpapi/DataGuruEngineService/actions");
            var request = new RestRequest(Method.GET);
            response = client.Execute(request);
            content = response.Content;
        }
        
        [Then(@"I expect to see status (.*)")]
        public void ThenIExpectToSeeStatus(int status)
        {
            System.Net.HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            Console.WriteLine(numericStatusCode);
            Assert.AreEqual(status, numericStatusCode);
        }
        
        [Then(@"I expect to see ""(.*)"" in the response body")]
        public void ThenIExpectToSeeInTheResponseBody(string keyword)
        {

            Assert.IsTrue(content.Contains(keyword));
        }
    }
}
