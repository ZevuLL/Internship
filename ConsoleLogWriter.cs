// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php
using System;

namespace Logg
{
    class ConsoleLogWriter : ILogWriter
    {
        private ConsoleColor ccb = Console.ForegroundColor;
        private void ChangeColorConsole(int Color) => Console.ForegroundColor = (ConsoleColor)Color;
        private void ReturnColorConsole() => Console.ForegroundColor = ccb;
        public void Write(AppEvent appEvent)
        {
             //var ccb = Console.ForegroundColor;
            if (appEvent.Level.ToString() == "Error")
            {
                ChangeColorConsole(12);
                Console.WriteLine($"{appEvent.EventTime.ToLongTimeString()} {appEvent.EventTime.ToShortDateString()} | {appEvent.Level} | {appEvent.Message}");
                ReturnColorConsole();
            }
            else if (appEvent.Level.ToString() == "Warn")
            {
                ChangeColorConsole(14);
                Console.WriteLine($"{appEvent.EventTime.ToLongTimeString()} {appEvent.EventTime.ToShortDateString()} | {appEvent.Level}  | {appEvent.Message}");
                ReturnColorConsole();
            }
            else if(appEvent.Level.ToString() == "Info")
            {
                ChangeColorConsole(10);
                Console.WriteLine($"{appEvent.EventTime.ToLongTimeString()} {appEvent.EventTime.ToShortDateString()} | {appEvent.Level}  | {appEvent.Message}");
                ReturnColorConsole();
            }
            else
            {
                ChangeColorConsole(10);
                Console.WriteLine($"{appEvent.EventTime.ToLongTimeString()} {appEvent.EventTime.ToShortDateString()} | {appEvent.Level} | {appEvent.Message}");
                ReturnColorConsole();
            }

            //цвета тут, и форматирование строк(расстояне)
            //Console.WriteLine($"{appEvent.EventTime.ToLongTimeString()} {appEvent.EventTime.ToLongDateString()} | {appEvent.Level} | {appEvent.Message}");
        }
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