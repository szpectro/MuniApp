


using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<int>>> SendEmail(EmailDto request)
        {
            var response = _emailService.SendEmailLink(request);
           
            return Ok(response);
        }
    }
}
