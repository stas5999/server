using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeldingControl.Business.Core.Employees.Queries.GetProfile;
using WeldingControl.Presentation.Web.Auth;

namespace WeldingControl.Presentation.Web.Controllers
{
    public class EmployeesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<ProfileDto>> Get()
        {
            var user = HttpContext.GetUserDataFromJwt();

            return Ok(await Mediator.Send(new GetProfileQuery
            {
                UserName = user.UserName,
            }));
        }
    }
}