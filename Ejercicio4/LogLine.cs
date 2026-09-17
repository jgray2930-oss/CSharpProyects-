public static class LogLine
{
    public static string Message(string logLine)
    {
        string[] parts = logLine.Split(':');
        return parts[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] parts = logLine.Split(':');
        return parts[0]
            .Replace("[", "")
            .Replace("]", "")
            .ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = LogLine.Message(logLine);
        string level = LogLine.LogLevel(logLine);

        return message + " (" + level + ")";
    }
}