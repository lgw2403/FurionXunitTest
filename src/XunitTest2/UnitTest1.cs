using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace XunitTest2
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        private const string url = "/WeatherForecast";

        public UnitTest1(WebApplicationFactory<Program> factory)
        {
            this._factory = factory;
        }

        [Fact]
        public async Task Test1()
        {
            using var httpClient = _factory.CreateClient();
            using var response = await httpClient.GetAsync($"{url}");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}