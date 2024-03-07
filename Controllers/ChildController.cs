using Bhcirs.Models;
using Bhcirs.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bhcirs.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChildController : Controller
    {
        ChildServices xservices;

        public ChildController(ChildServices xservices)
        {
            this.xservices = xservices;
        }

        [HttpGet]
        public async Task<List<child>> Child()
        {
            var ret = await xservices.Child();
            return ret;
        }

        [HttpPost]
        public async Task<int> AddChild([FromBody] child xchild)
        {
            var ret = await xservices.AddChild(xchild);
            return ret;
        }

        [HttpPut]
        public async Task<int> UpdateChild([FromBody] child xchild)
        {
            var ret = await xservices.UpdateChild(xchild);
            return ret;
        }

        [HttpGet]
        public async Task<List<child>> SearchChild(string search)
        {
            var ret = await xservices.SearchChild(search);
            return ret;
        }

        [HttpGet]
        public async Task<int> CountChild()
        {
            return await xservices.CountChild();
        }
    }
}