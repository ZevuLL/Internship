// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php

namespace Logg
{
    interface ILogWriter
    {
        void Write(AppEvent appEvent);
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