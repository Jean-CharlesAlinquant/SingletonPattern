
using DesignPatters.Singleton;

LoggerBase singleton1 = LazySingletonLogger.GetInstance();
LoggerBase singleton2 = LazySingletonLogger.GetInstance();

if (ReferenceEquals(singleton1, singleton2))
{
    Console.WriteLine("Same instance, singleton pattern successfully implemented.");
}

singleton1.Log("This message is logged using a singleton logging system.");
