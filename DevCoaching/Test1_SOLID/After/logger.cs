namespace DevCoaching.Test1_SOLID.After;


public interface ILogger
{
    void Log(string message);
}
    
public class Logger : ILogger
{
    public void Log(string message)
    {
    }
}
