using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyController : ControllerBase
    {
        private readonly IMoneyService _moneyService;

        public MoneyController(IMoneyService moneyService)
        {
            _moneyService = moneyService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Valores>>>> GetValores()
        {
            var result = await _moneyService.GetValores();
            return Ok(result);
        }
    }
}
