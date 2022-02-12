using Xunit;
using System;
using Shouldly;
using TechTalk.SpecFlow;
using LoginComponentTest.Fixture;

namespace LoginComponentTest.Steps
{
    [Binding]
    public class LoginSteps : IClassFixture<LoginTestFixture>
    {
        private LoginTestFixture fixture;
        const string success = "You logged into a secure area!";
        const string securPageUrl = "https://the-internet.herokuapp.com/secure";
        public LoginSteps(LoginTestFixture fixture)
        {
            this.fixture = fixture;
        }

        [Then(@"login process should be success")]
        public void ThenLoginProcessShouldBeSuccess()
        {
            fixture.SecureActions.GetPageUrl().ShouldBe(securPageUrl);
            fixture.SecureActions.GetSuccessMesg().ShouldContain(success);
            fixture.WaitForSeconds(1);
        }

        [Then(@"(.*) is showed")]
        public void IsShowed(string eMsg)
        {
            fixture.LoginActions.GetErrorMsg().ShouldContain(eMsg);
            fixture.WaitForSeconds(1);
        }

    }
}
