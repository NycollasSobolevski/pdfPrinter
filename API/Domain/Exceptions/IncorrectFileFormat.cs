namespace PrinterApi.Domain.Exception;

public class IncorrectFileFormat : System.Exception
{
    public IncorrectFileFormat() { }
    public IncorrectFileFormat(string message) : base(message) { }
    public IncorrectFileFormat(string message, System.Exception inner) : base(message, inner) { }

}