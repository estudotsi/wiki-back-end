using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using WikiGC.Data;
using WikiGC.Models;

namespace WikiGC.Controllers
{
    [ApiController]
    public class PortalPDFController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PortalPDFController(DataContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        [Route("listPDF")]
        [ProducesResponseType(typeof(List<Portais>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Portais>>> ListProducts()
        {
            try
            {
                var portaisPDF = await _context.Portais.ToListAsync();

                if (portaisPDF is null)
                    return NotFound();

                return Ok(portaisPDF);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

       /* [Route("report")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Portais>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<Portais>>> ReportProducts()
        {
            try
            {
                var portaisPdf = await _context.Portais.ToListAsync();

                if (portaisPdf is null)
                    return NotFound();

                var webReport = new WebReport();

                webReport.Report.Load(Path.Combine(_webHostEnvironment.ContentRootPath,
                    "wwwroot/reports", "productsreport.frx"));

                GenerateDataTableReport(portaisPdf, webReport);

                webReport.Report.Prepare();

                using MemoryStream stream = new MemoryStream();

                webReport.Report.Export(new PDFSimpleExport(), stream);

                stream.Flush();
                byte[] arrayReport = stream.ToArray();

                return File(arrayReport, "application/zip", "ProductsReport.pdf");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GenerateDataTableReport(List<Portais> products, WebReport webReport)
        {
            var portaisDataTable = new DataTable();
            portaisDataTable.Columns.Add("ProductName", typeof(string));
            portaisDataTable.Columns.Add("UnitsInStock", typeof(int));
            portaisDataTable.Columns.Add("UnitPrice", typeof(decimal));

            foreach (var item in products)
            {
                portaisDataTable.Rows.Add(item.Nome,
                               item.UrlProducao, item.Responsavel);
            }
            //registra o datatable para usar no relatorio
            webReport.Report.RegisterData(portaisDataTable, "Products");
        }*/
    }
}
