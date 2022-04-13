
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Xunit;

namespace HealthCheckTest.Test
{
    public class ProgramTests : IClassFixture<Application>
    {
        private readonly Application applicationFactory;

        private const string APPLICATION_STATUS_RESPONSE = "\"ApplicationStatus\":\"Healthy\"";

        public ProgramTests(Application applicationFactory)
        {
            this.applicationFactory = applicationFactory;
        }

        [Fact]
        public async Task Given_HealthCheckConfigured_When_ApplicationOn_Then_ShouldReturnApiHealthStatus200_And_ExpectedResponseBody()
        {
            var application = applicationFactory.CreateClient();
            var response = await application.GetAsync("/health");
            var responseCode = (int)response.StatusCode;
            var responseContent = await response.Content.ReadAsStringAsync();
            responseCode.Should().Be(StatusCodes.Status200OK);
            responseContent.Should().Contain(APPLICATION_STATUS_RESPONSE);
        }

    }
}