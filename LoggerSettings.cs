// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php
using System.Collections.Generic;


namespace Logg
{
    class LoggerSettings
    {
        public LoggerSettings()
        {
            Outputs = new List<LogOutput>
            {
            LogOutput.Console, LogOutput.File,LogOutput.DataBase
            };
        }

        // The list of outputs the created logger should use.
        public IEnumerable<LogOutput> Outputs { get; }
    }
}