// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php
using System.Collections;
using System.IO;
using System;


namespace Logg
{
    partial class Program
    {
        static void Main(string[] args)
        {
            RunLoggerTest();
        }

        static void RunLoggerTest()
        {
            // usually settings are set from a config file,
            // but for this task we decided to just create them:
            var loggerSettings = new LoggerSettings();
            // the factory creates logger depending on configuration: 
            var loggerFactory = new LoggerFactory(loggerSettings);
            ILog logger = loggerFactory.CreateLogger();
            // then the logger can be used inside classes:
            var myService = new MyService(logger);
            myService.MyMethod();
        }
        /*
        Sample output:
        2021-08-27 17:28:01.105 | DEBUG | Debug message sample.
        2021-08-27 17:28:01.396 | INFO  | Info message sample.
        2021-08-27 17:28:01.601 | WARN  | Warning message sample.
        2021-08-27 17:28:01.798 | ERROR | Error message sample.
        */
    }
    // Specifies supported log output types.
    enum LogOutput
    {
        Console,
        File,
        DataBase
    }
    enum LogLevel
    {
        Debug,
        Info,
        Warn,
        Error,
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