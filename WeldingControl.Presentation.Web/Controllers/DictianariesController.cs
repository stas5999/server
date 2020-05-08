using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeldingControl.Business.Core.Dictionaries.Queries.GetDictionaries;
using WeldingControl.Presentation.Web.Auth;

namespace WeldingControl.Presentation.Web.Controllers
{
    public class DictianariesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<DictionariesDto>> Get()
        {
            return Ok(await Mediator.Send(new GetDictionariesQuery()));
        }
    }
}
