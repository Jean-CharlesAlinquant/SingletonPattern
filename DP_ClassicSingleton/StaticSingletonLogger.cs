namespace DesignPatters.Singleton;

// Not thread safe
// No lazy instantiation
public class StaticSingletonLogger : LoggerBase
{
    private static readonly StaticSingletonLogger _instance =
        new StaticSingletonLogger();

    private StaticSingletonLogger() { }

    public static StaticSingletonLogger GetInstance()
    {
        return _instance;
    }
}
