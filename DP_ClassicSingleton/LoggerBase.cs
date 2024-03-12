namespace DesignPatters.Singleton;

public abstract class LoggerBase
{
    public void Log(Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }

    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
