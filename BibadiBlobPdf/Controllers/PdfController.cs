using BibadiBlobPdf.Core.Services;
using BibadiBlobPdf.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibadiBlobPdf.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PdfController : Controller
    {
        IPdfService _pdfService;
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public PdfController(IPdfService pdfService) => _pdfService = pdfService;

        [HttpPost("ConvertHtmlToPdf")]
        public async Task<IActionResult> ConvertHtmlToPdf([FromBody] Html html)
        {
            var pdf = await _pdfService.ConvertHtmlToPdf(html);
            return Ok(pdf);
        }

        [HttpPost("ConvertImgToPdf")]
        public async Task<IActionResult> ConvertImgToPdf([FromBody] Img img)
        {
            var pdf = await _pdfService.ConvertImgToPdf(img);
            return Ok(pdf);
        }

        [HttpPost("CombinePdfs")]
        public async Task<IActionResult> CombinePdfs([FromBody] PdfList pdfs)
        {
            var pdf = await _pdfService.CombinePdfs(pdfs);
            return Ok(pdf);
        }
    }
}
