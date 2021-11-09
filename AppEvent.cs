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
    /*
    ## Split up the task:

    ILog - interface for using in services
    Logger - class, describes logger

    - create the logger based on the logging setting
    - create an event description object -> class Logger : ILog
    - class AppEvent -> attributes: EventTime, Level, Message
    - write to file
    - write to console

    Logger
    AppEvent: EventTime, Level, Message
    ILogWriter

    */
}