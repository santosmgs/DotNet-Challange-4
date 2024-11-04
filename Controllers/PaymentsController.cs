using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class PaymentsController : ControllerBase
{
    private readonly PaymentService _paymentService;

    public PaymentsController(PaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpPost]
    public async Task<IActionResult> CreatePayment([FromBody] PaymentRequest paymentRequest)
    {
        var result = await _paymentService.ProcessPayment(paymentRequest);
        return Ok(result);
    }
}