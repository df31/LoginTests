using TechTalk.SpecFlow;
using Microsoft.Extensions.Configuration;

namespace LoginComponentTest
{
    [Binding]
    public static class Startup
    {
        public static IConfiguration Config { get; private set; }

        [BeforeTestRun]
        public static void InitConfiguration()
        {
            Config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
