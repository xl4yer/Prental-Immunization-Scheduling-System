using Bhcirs.Class;
using Bhcirs.Models;
using Bhcirs.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using System.Data;

namespace Bhcirs.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImmunizationController : Controller
    {
        ImmunizationServices xservices;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ImmunizationController(ImmunizationServices xservices, IWebHostEnvironment webHostEnvironment)
        {
            this.xservices = xservices;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> BCG()
        {
            var ret = await xservices.BCG();
            return ret;
        }


        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> IPV1()
        {
            var ret = await xservices.IPV1();
            return ret;
        }


        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> IPV2()
        {
            var ret = await xservices.IPV2();
            return ret;
        }


        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> MMR1()
        {
            var ret = await xservices.MMR1();
            return ret;
        }


        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> MMR2()
        {
            var ret = await xservices.MMR2();
            return ret;
        }


        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> PCV131()
        {
            var ret = await xservices.PCV131();
            return ret;
        }


        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> PCV132()
        {
            var ret = await xservices.PCV132();
            return ret;
        }


        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> PCV133()
        {
            var ret = await xservices.PCV133();
            return ret;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> BOPV1()
        {
            var ret = await xservices.BOPV1();
            return ret;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> BOPV2()
        {
            var ret = await xservices.BOPV2();
            return ret;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> BOPV3()
        {
            var ret = await xservices.BOPV3();
            return ret;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> Penta1()
        {
            var ret = await xservices.Penta1();
            return ret;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<immunization>> Penta2()
        {
            var ret = await xservices.Penta2();
            return ret;
        }

        [HttpGet]
        [Authorize]
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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> BCGReport()
        {
            ListtoTable listtoTable = new();
            var dt = new DataTable();
            var lst = await xservices.BCG();
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

            return File(excel, "application/msexcel", "BCG.xls");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> PentaReport()
        {
            ListtoTable listtoTable = new();
            var dt = new DataTable();
            var lst = await xservices.Penta3();
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

            return File(excel, "application/msexcel", "Penta.xls");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> bOPVReport()
        {
            ListtoTable listtoTable = new();
            var dt = new DataTable();
            var lst = await xservices.BOPV3();
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

            return File(excel, "application/msexcel", "bOPV.xls");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> IPVReport()
        {
            ListtoTable listtoTable = new();
            var dt = new DataTable();
            var lst = await xservices.IPV2();
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

            return File(excel, "application/msexcel", "IPV.xls");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> MMRReport()
        {
            ListtoTable listtoTable = new();
            var dt = new DataTable();
            var lst = await xservices.MMR2();
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

            return File(excel, "application/msexcel", "MMR.xls");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> PCV13Report()
        {
            ListtoTable listtoTable = new();
            var dt = new DataTable();
            var lst = await xservices.PCV133();
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

            return File(excel, "application/msexcel", "PCV13.xls");
        }
    }
}
