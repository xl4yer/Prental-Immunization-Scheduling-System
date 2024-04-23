using Bhcirs.Class;
using Bhcirs.Models;
using Bhcirs.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Reporting.NETCore;
using System.Data;

namespace Bhcirs.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class PrenatalController : Controller
	{
		PrenatalServices xservices;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PrenatalController(PrenatalServices xservices, IWebHostEnvironment webHostEnvironment)
        {
			this.xservices = xservices;
            _webHostEnvironment = webHostEnvironment;
		}

		[HttpGet]
        [Authorize]
        public async Task<List<prenatal>> Teta1()
		{
			var ret = await xservices.Teta1();
			return ret;
		}

        [HttpGet]
        [Authorize]
        public async Task<List<prenatal>> Teta2()
        {
            var ret = await xservices.Teta2();
            return ret;
        }
        [HttpGet]
        [Authorize]
        public async Task<List<prenatal>> Teta3()
        {
            var ret = await xservices.Teta3();
            return ret;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<prenatal>> Teta4()
        {
            var ret = await xservices.Teta4();
            return ret;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<prenatal>> Teta5()
        {
            var ret = await xservices.Teta5();
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

        [HttpGet]
        public async Task<List<prenatal>> SearchTeta3(string search)
        {
            var ret = await xservices.SearchTeta3(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<prenatal>> SearchTeta4(string search)
        {
            var ret = await xservices.SearchTeta4(search);
            return ret;
        }

        [HttpGet]
        public async Task<List<prenatal>> SearchTeta5(string search)
        {
            var ret = await xservices.SearchTeta5(search);
            return ret;
        }

        [HttpGet]
        public async Task<int> CountTeta()
        {
            return await xservices.CountTeta();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> TetaReport()
        {
            ListtoTable listtoTable = new();
            var dt = new DataTable();
            var lst = await xservices.Teta5();
            dt = listtoTable.ToDataTablee(lst);
            string reportPath = Path.Combine(_webHostEnvironment.ContentRootPath, "Reports", "Report.rdlc");
            Stream reportDefinition;
            using var fs = new FileStream(reportPath, FileMode.Open);
            reportDefinition = fs;
            LocalReport report = new LocalReport();
            report.LoadReportDefinition(reportDefinition);
            report.DataSources.Add(new ReportDataSource("DataSet1", dt));
            byte[] excel = report.Render("EXCEL");
            fs.Dispose();

            return File(excel, "application/msexcel", "Tetanus.xls");
        }
    }
}
