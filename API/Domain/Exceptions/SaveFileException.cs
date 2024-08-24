namespace PrinterApi.Domain.Exception;

public class SaveFileException : System.Exception
{
    public SaveFileException() { }
    public SaveFileException(string message) : base(message) { }
    public SaveFileException(string message, System.Exception inner) : base(message, inner) { }

}