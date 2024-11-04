using Microsoft.AspNetCore.Mvc.Testing;
using System.Text;
using Newtonsoft.Json;
using WorkerService1;
using Xunit;

public class PaymentsIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;

    public PaymentsIntegrationTests(WebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task CreatePayment_ValidRequest_ReturnsSuccess()
    {
        // Arrange
        var paymentRequest = new
        {
            Amount = 100.00m,
            Currency = "USD",
            PaymentMethod = "CreditCard"
        };
        var content = new StringContent(JsonConvert.SerializeObject(paymentRequest), Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PostAsync("/api/payments", content);

        // Assert
        response.EnsureSuccessStatusCode(); // Verifica se o status da resposta é 2xx
        var responseContent = await response.Content.ReadAsStringAsync();
        Assert.NotNull(responseContent); // Verifica se a resposta não é nula
    }

    [Fact]
    public async Task CreatePayment_InvalidRequest_ReturnsBadRequest()
    {
        // Arrange
        var invalidPaymentRequest = new
        {
            Amount = 0.00m, // Valor inválido
            Currency = "USD",
            PaymentMethod = "CreditCard"
        };
        var content = new StringContent(JsonConvert.SerializeObject(invalidPaymentRequest), Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PostAsync("/api/payments", content);

        // Assert
        Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode); // Verifica se o status da resposta é 400
    }
}