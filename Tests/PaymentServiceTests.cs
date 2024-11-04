// Tests/PaymentServiceTests.cs
using Xunit;
using Moq;

public class PaymentServiceTests
{
    [Fact]
    public async Task ProcessPayment_ReturnsResponse()
    {
        var mockHttpClient = new Mock<HttpClient>();
        var service = new PaymentService(mockHttpClient.Object);

        var paymentRequest = new PaymentRequest { Amount = 100, Currency = "USD", PaymentMethod = "CreditCard" };
        
        var result = await service.ProcessPayment(paymentRequest);

        Assert.NotNull(result);
    }
}