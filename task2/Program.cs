{
    Logger logger1 = new Logger(new ConsoleLogger());
    Logger logger2 = new Logger(new FileLogger());
    logger1.CreateLog("Log1");
    logger2.CreateLog("Log2");
}

interface ILogger
{
    public void Log(string message);
}
class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"ConsloleLog: {message}");
    }
}
class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log '{message}' written to file");
    }
}
class Logger
{
    private ILogger _logger;
    public Logger(ILogger logger) {  _logger = logger; }
    public void CreateLog(string message)
    {
        _logger.Log(message);
    }
}