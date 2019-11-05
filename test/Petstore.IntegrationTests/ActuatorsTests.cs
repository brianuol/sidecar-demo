using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Steeltoe.Common.HealthChecks;
using Xunit;

namespace Petstore.IntegrationTests
{
    public class ActuatorTests : IClassFixture<WebApplicationFactory<Startup>>
    {

        private readonly WebApplicationFactory<Startup> _factory;

        public ActuatorTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task When_AppIsHealthy_HealthEndpoint_Should_ReturnUpStatus()
        {
            var client = _factory.CreateClient();
            var url = "/health_checks";
            var expectedStatus = HealthStatus.UP;

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Status Code 200-299

            var actual = JsonConvert.DeserializeObject<HealthCheckResult>(await response.Content.ReadAsStringAsync());
            expectedStatus.Should().BeEquivalentTo(actual.Status);
        }
    }
}
