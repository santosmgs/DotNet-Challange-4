using System.Text;
using Newtonsoft.Json;

public class PaymentService
{
    private readonly HttpClient _httpClient;

    public PaymentService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> ProcessPayment(PaymentRequest request)
    {
        var jsonContent = JsonConvert.SerializeObject(request);
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
        
        var response = await _httpClient.PostAsync("https://api.paymentprovider.com/process", content);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}