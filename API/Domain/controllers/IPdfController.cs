using Microsoft.AspNetCore.Mvc;
using PrinterApi.Domain.Services;

namespace PrinterApi.Domain.Controller;

public interface IPdfController
{
    public Task<ActionResult> GetPdfAsync([FromServices] IPdfService pdfService, IFormFile file);
}