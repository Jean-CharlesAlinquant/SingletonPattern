namespace DesignPatters.Singleton;

// Thread safe
public class LazySingletonLogger : LoggerBase
{
    private static readonly Lazy<LazySingletonLogger> _instance =
        new Lazy<LazySingletonLogger>(() => new LazySingletonLogger());

    private LazySingletonLogger() { }

    public static LazySingletonLogger GetInstance()
    {
        return _instance.Value;
    }
}
