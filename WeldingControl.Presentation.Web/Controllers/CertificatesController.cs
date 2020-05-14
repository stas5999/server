using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WeldingControl.Business.Core.Employees.Queries.GetCertificates;
using WeldingControl.Presentation.Web.Auth;

namespace WeldingControl.Presentation.Web.Controllers
{
    public class CertificatesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<CertificatesDto>> Get()
        {
            var certificate = HttpContext.GetUserDataFromJwt();

            return Ok(await Mediator.Send(new GetCertificatesQuery
            { 
                Id = certificate.Id
            }));
        }

        [HttpGet]
        public async Task<ActionResult<CertificatesDto>> Get(int Id)
        {
            return Ok(await Mediator.Send(new GetCertificatesQuery()));
        }
    }
}
