// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php
using System;


namespace Logg
{
    //under call
    class AppEvent
    {
        public DateTime EventTime { get; set; }
        public LogLevel Level { get; set; }
        public string Message { get; set; }
    }
}