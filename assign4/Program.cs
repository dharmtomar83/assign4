using System;

static class assign4
{
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}

class Program
{
    static void Main()
    {
        assign4.LogMessage("This is a log message.");
        assign4.LogMessage("Another log message.");

        Console.WriteLine("Logging demonstration completed.");
    }
}
