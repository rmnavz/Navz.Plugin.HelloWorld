namespace Navz.Plugin.HelloWorld.UnitTest.Helpers;
public class ConsoleOutput : IDisposable
{
    private readonly System.IO.StringWriter _stringWriter;
    private readonly TextWriter _originalOutput;

    public ConsoleOutput()
    {
        _stringWriter = new System.IO.StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_stringWriter);
    }

    public string GetOutput() => _stringWriter.ToString();

    public void Dispose()
    {
        Console.SetOut(_originalOutput);
        _stringWriter.Dispose();
    }
}