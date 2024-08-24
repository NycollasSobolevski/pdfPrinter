using Microsoft.AspNetCore.Mvc;
using PrinterApi.Domain.Controller;
using PrinterApi.Domain.Services;

namespace PrinterApi.Core.Controller;

public class PdfController : ControllerBase, IPdfController
{
    public async Task<ActionResult> GetPdfAsync([FromServices] IPdfService pdfService, IFormFile file)
    {
        try {
            await pdfService.GetFile(file);
            return Ok();

        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}