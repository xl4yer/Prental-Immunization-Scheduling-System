using Bhcirs.Models;
using Bhcirs.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bhcirs.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class PrenatalController : Controller
	{
		PrenatalServices xservices;

		public PrenatalController(PrenatalServices xservices)
		{
			this.xservices = xservices;
		}

		[HttpGet]
		public async Task<List<prenatal>> Teta1()
		{
			var ret = await xservices.Teta1();
			return ret;
		}

        [HttpGet]
        public async Task<List<prenatal>> Teta2()
        {
            var ret = await xservices.Teta2();
            return ret;
        }

        [HttpPost]
        public async Task<int> AddPrenatal([FromBody] prenatal xpre)
        {
            var ret = await xservices.AddPrenatal(xpre);
            return ret;
        }

        [HttpPut]
        public async Task<int> UpdatePrenatal([FromBody] prenatal xpre)
        {
            var ret = await xservices.UpdatePrenatal(xpre);
            return ret;
        }

        [HttpGet]
        public async Task<List<prenatal>> SearchTeta1(string search)
        {
            var ret = await xservices.SearchTeta1(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<prenatal>> SearchTeta2(string search)
        {
            var ret = await xservices.SearchTeta2(search);
            return ret;
        }
    }
}
