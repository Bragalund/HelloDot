using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace HelloDotTestProject{

    public class IntegrationTests : IClassFixture<CustomWebApplicationFactory<helloDotApi.Startup>>
{
    private readonly HttpClient _client;
    private readonly CustomWebApplicationFactory<helloDotApi.Startup> _factory;
public IntegrationTests(CustomWebApplicationFactory<helloDotApi.Startup> factory){
        _factory = factory;
        _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
}

        [Fact]
        public async void TestThatWebPageRetunrs200Async(){

// Arrange
    var defaultPage = await _client.GetAsync("/api/values");

    // Assert
    Assert.Equal(HttpStatusCode.OK, defaultPage.StatusCode);
        }
    }
} 