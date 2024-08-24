namespace PrinterApi.Domain.Services;

public interface IFileService
{
    public bool Verify(IFormFile file);
    public void Print(IFormFile file);
    public void SaveFile(IFormFile file);
    public Task GetFile(IFormFile file);
}