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
        public async Task<List<immunization>> IPV1()
        {
            var ret = await xservices.IPV1();
            return ret;
        }


        [HttpGet]
        public async Task<List<immunization>> IPV2()
        {
            var ret = await xservices.IPV2();
            return ret;
        }


        [HttpGet]
        public async Task<List<immunization>> MCV1()
        {
            var ret = await xservices.MCV1();
            return ret;
        }


        [HttpGet]
        public async Task<List<immunization>> MCV2()
        {
            var ret = await xservices.MCV2();
            return ret;
        }


        [HttpGet]
        public async Task<List<immunization>> PCV131()
        {
            var ret = await xservices.PCV131();
            return ret;
        }


        [HttpGet]
        public async Task<List<immunization>> PCV132()
        {
            var ret = await xservices.PCV132();
            return ret;
        }


        [HttpGet]
        public async Task<List<immunization>> PCV133()
        {
            var ret = await xservices.PCV133();
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> BOPV1()
        {
            var ret = await xservices.BOPV1();
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> BOPV2()
        {
            var ret = await xservices.BOPV2();
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> BOPV3()
        {
            var ret = await xservices.BOPV3();
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
