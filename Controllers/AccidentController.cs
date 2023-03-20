using MediatR;
using MediatRNotifications.MediatR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRNotifications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccidentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccidentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("notify-accident")]
        public async Task<IActionResult> NotifyAboutAccident(AccidentNotification notification)
        {
            await _mediator.Publish(notification);

            return Ok();
        }
    }
}
