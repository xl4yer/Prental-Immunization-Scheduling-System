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
        public async Task<List<immunization>> MMR1()
        {
            var ret = await xservices.MMR1();
            return ret;
        }


        [HttpGet]
        public async Task<List<immunization>> MMR2()
        {
            var ret = await xservices.MMR2();
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

        [HttpPut]
        public async Task<int> UpdateImmunization([FromBody] immunization ximm)
        {
            var ret = await xservices.UpdateImmunization(ximm);
            return ret;
        }



        [HttpGet]
        public async Task<List<immunization>> SearchBCG(string search)
        {
            var ret = await xservices.SearchBCG(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchPenta1(string search)
        {
            var ret = await xservices.SearchPenta1(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchPenta2(string search)
        {
            var ret = await xservices.SearchPenta2(search);
            return ret;
        }


        [HttpGet]
        public async Task<List<immunization>> SearchPenta3(string search)
        {
            var ret = await xservices.SearchPenta3(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchBOPV1(string search)
        {
            var ret = await xservices.SearchBOPV1(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchBOPV2(string search)
        {
            var ret = await xservices.SearchBOPV2(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchBOPV3(string search)
        {
            var ret = await xservices.SearchBOPV3(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchIPV1(string search)
        {
            var ret = await xservices.SearchIPV1(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchIPV2(string search)
        {
            var ret = await xservices.SearchIPV2(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchPCV131(string search)
        {
            var ret = await xservices.SearchPCV131(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchPCV132(string search)
        {
            var ret = await xservices.SearchPCV132(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchPCV133(string search)
        {
            var ret = await xservices.SearchPCV133(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchMMR1(string search)
        {
            var ret = await xservices.SearchMMR1(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<immunization>> SearchMMR2(string search)
        {
            var ret = await xservices.SearchMMR2(search);
            return ret;
        }

        [HttpGet]
        public async Task<int> CountPenta()
        {
            return await xservices.CountPenta();
        }


        [HttpGet]
        public async Task<int> CountBOPV()
        {
            return await xservices.CountBOPV();
        }

        [HttpGet]
        public async Task<int> CountBCG()
        {
            return await xservices.CountBCG();
        }

        [HttpGet]
        public async Task<int> CountIPV()
        {
            return await xservices.CountIPV();
        }

        [HttpGet]
        public async Task<int> CountMMR()
        {
            return await xservices.CountMMR();
        }

        [HttpGet]
        public async Task<int> CountPCV13()
        {
            return await xservices.CountPCV13();
        }
    }
}
