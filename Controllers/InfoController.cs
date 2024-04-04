using Bhcirs.Models;
using Bhcirs.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bhcirs.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InfoController : Controller
    {
        InfoServices xservices;

        public InfoController(InfoServices xservices)
        {
            this.xservices = xservices;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<info>> Info()
        {
            var ret = await xservices.Info();
            return ret;
        }

        [HttpGet]
        public async Task<List<info>> SearchInfo(string search)
        {
            var ret = await xservices.SearchInfo(search);
            return ret;
        }

        [HttpPost]
        public async Task<int> AddInfo([FromBody] info xinfo)
        {
            var ret = await xservices.AddInfo(xinfo);
            return ret;
        }

        [HttpPut]
        public async Task<int> UpdateInfo([FromBody] info xinfo)
        {
            var ret = await xservices.UpdateInfo(xinfo);
            return ret;
        }

        [HttpGet]
        public async Task<int> CountInfo()
        {
            return await xservices.CountInfo();
        }
    }
}