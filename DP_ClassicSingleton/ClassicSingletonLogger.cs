namespace DesignPatters.Singleton;

// If multiple threads call the GetInstance method simultaneously, 
// it's possible for more than one instance of ClassicSingletonLogger 
// to be created
public class ClassicSingletonLogger : LoggerBase
{
    private static ClassicSingletonLogger? _instance;

    private ClassicSingletonLogger() { }

    public static ClassicSingletonLogger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new ClassicSingletonLogger();
        }

        return _instance;
    }
}
