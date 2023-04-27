using System;
namespace Learning;

interface ILogger
{
    void Log(string message);
    void LogError(string errorMessage);
}

class FileLogger : ILogger
{
    string filePath;
    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }
    public void Log(string message)
    {
        using(StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(message);
        }
    }
    public void LogError(string errorMessage)
    {
        using(StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine("ERROR: " + errorMessage);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        ILogger ins = new FileLogger("log.txt");
        ins.Log("This is a log message!");
        ins.LogError("This is an error message!"); 

    }
}
