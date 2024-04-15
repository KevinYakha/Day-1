using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.IndexOf(':') + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        string temp = logLine.Remove(logLine.IndexOf(']'));
        return temp.Remove(0, 1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return Message(logLine) + " (" + LogLevel(logLine) + ')';
    }
}
