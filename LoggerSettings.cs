// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php
using System.Collections.Generic;


namespace Logg
{
    // A simplified logger configuration class.
    // For now let's create it in-code instead of loading the settings from a file.
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