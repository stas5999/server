using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WeldingControl.Presentation.Web.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class BaseController : Controller
    {
        private IMediator _mediator;

        public IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}