 
using Microsoft.AspNetCore.Mvc;
using VueAPI.DTOs;
using VueAPI.Services;

namespace AppApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmailController : ControllerBase
{
    private readonly IEmailService _emailService;

    public EmailController(IEmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpPost]
    public IActionResult SendEmail(EmailDto request)
    {
        _emailService.SendEmail(request);
        return Ok();
    }
}
