using Bhcirs.Models;
using Bhcirs.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bhcirs.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImmunizationController : Controller
    {
        ImmunizationServices xservices;

        public ImmunizationController(ImmunizationServices xservices)
        {
            this.xservices = xservices;
        }

        [HttpGet]
        public async Task<List<immunization>> BCG()
        {
            var ret = await xservices.BCG();
            return ret;
        }


        [HttpPost]
        public async Task<int> AddImmunization([FromBody] immunization ximm)
        {
            var ret = await xservices.AddImmunization(ximm);
            return ret;
        }
    }
}
