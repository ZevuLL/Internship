// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php
using System;
using System.Collections.Generic;


namespace Logg
{
    internal class LoggerFactory
    {
        private LoggerSettings loggerSettings;
        private ILog logger;
        public LoggerFactory(LoggerSettings loggerSettings)
        {
            this.loggerSettings = loggerSettings;
        }
        internal ILog CreateLogger()
        {
            List<ILogWriter> writers = new List<ILogWriter>();
            foreach (LogOutput settings in loggerSettings.Outputs)
            {
                switch (settings)
                {
                    case LogOutput.File:
                        writers.Add(new FileLogWriter());
                        break;
                    case LogOutput.Console:
                        writers.Add(new ConsoleLogWriter());
                        break;
                    case LogOutput.DataBase:
                        writers.Add(new DataBaseLogWriter());
                        break;
                }
            }

            logger = new Logger(writers);
            return logger;
        }
    }
}