namespace PrinterApi.Domain.Exception;

public class PrintFileException : System.Exception
{
    public PrintFileException() { }
    public PrintFileException(string message) : base(message) { }
    public PrintFileException(string message, System.Exception inner) : base(message, inner) { }

}