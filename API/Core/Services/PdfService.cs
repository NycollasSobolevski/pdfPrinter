using PrinterApi.Domain.Exception;
using PrinterApi.Domain.Services;

namespace PrinterApi.Core.Services;


public class PdfService : IPdfService
{
    private readonly string defaultFilePath =  Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);

    public async Task GetFile(IFormFile file)
    {
        this.Verify(file);
        this.SaveFile(file);
        this.Print(file);
    }

    public void Print(IFormFile file)
    {
        try {

            throw new NotImplementedException();
        } catch (Exception ex) {
            System.Console.WriteLine(ex);
            throw new PrintFileException();
        }
    }

    public async void SaveFile(IFormFile file)
    {
        try {
            var filePath = Path.Combine(defaultFilePath, file.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        } catch (Exception ex) {
            System.Console.WriteLine(ex);
            throw new SaveFileException();
        }

    }

    public bool Verify(IFormFile file)
    {
        if (file == null || file.Length == 0 || !file.ContentType.Equals("application/pdf"))
            throw new IncorrectFileFormat();

        return true;
    }
}