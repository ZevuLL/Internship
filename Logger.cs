// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php
using System;
using System.Collections.Generic;


namespace Logg
{
    class Logger : ILog
    {
        private readonly IEnumerable<ILogWriter> writers;

        public Logger(IEnumerable<ILogWriter> writers)
        {
            this.writers = writers;
        }

        public void Debug(string message)
        {
            WriteLog(message, LogLevel.Debug);
        }

        public void Error(string message)
        {
            WriteLog(message, LogLevel.Error);
        }

        public void Info(string message)
        {
            WriteLog(message, LogLevel.Info);
        }

        public void Warning(string message)
        {
            WriteLog(message, LogLevel.Warn);
        }
        private void WriteLog(string message, LogLevel logLevel)
        {
            var appEvent = new AppEvent
            {
                EventTime = DateTime.Now,
                Level = logLevel,
                Message = message
            };
            foreach (var writer in writers) writer.Write(appEvent);
        }
    }
}