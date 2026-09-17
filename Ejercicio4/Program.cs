string logEntry = "[ERROR]: Something went wrong";

Console.WriteLine(LogLine.Message(logEntry));
Console.WriteLine(LogLine.LogLevel(logEntry));
Console.WriteLine(LogLine.Reformat(logEntry));
