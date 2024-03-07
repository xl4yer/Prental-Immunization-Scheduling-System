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

        [HttpGet]
        public async Task<List<immunization>> Penta1()
        {
            var ret = await xservices.Penta1();
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> Penta2()
        {
            var ret = await xservices.Penta2();
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> Penta3()
        {
            var ret = await xservices.Penta3();
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
