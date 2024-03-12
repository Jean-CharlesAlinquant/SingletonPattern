namespace DesignPatters.Singleton;

// Thread safe with use of double-checked locking pattern
public class ThreadSafeSingletonLogger : LoggerBase
{
    private static readonly Object _lock = new Object();

    private static ThreadSafeSingletonLogger? _instance;

    private ThreadSafeSingletonLogger() { }

    public static ThreadSafeSingletonLogger GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingletonLogger();
                }

            }
        }
        return _instance;
    }
}
