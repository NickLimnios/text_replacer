using System;

namespace TextReplacer
{
    public interface  ILogger
    {
        void AddLogEntry(string message, LogEntryLevel logEntryLevel);
        void AddLogEntry(string message, LogEntryLevel logEntryLevel, Exception ex);
    }

    public enum LogEntryLevel{
        Info,
        Warning,
        Error
    }
}
