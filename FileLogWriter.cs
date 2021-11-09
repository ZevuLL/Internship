// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php
using System.IO;
using System;


namespace Logg
{
    class FileLogWriter : ILogWriter
    {
        private static String CurrentDirectory = Directory.GetCurrentDirectory();
        private static String FileName = "Log.txt";
        private static String FilePath = CurrentDirectory + "/" + FileName;
        public void Write(AppEvent appEvent)
        {
            using (StreamWriter writer = File.AppendText(FilePath))
            {
                if (appEvent.Level.ToString() == "Error")
                {
                    writer.WriteLine($"{appEvent.EventTime.ToLongTimeString()} {appEvent.EventTime.ToShortDateString()} | {appEvent.Level} | {appEvent.Message}");
                }
                else if (appEvent.Level.ToString() == "Warn")
                {
                    writer.WriteLine($"{appEvent.EventTime.ToLongTimeString()} {appEvent.EventTime.ToShortDateString()} | {appEvent.Level}  | {appEvent.Message}");
                }
                else if (appEvent.Level.ToString() == "Info")
                {
                    writer.WriteLine($"{appEvent.EventTime.ToLongTimeString()} {appEvent.EventTime.ToShortDateString()} | {appEvent.Level}  | {appEvent.Message}");
                }
                else
                {
                    writer.WriteLine($"{appEvent.EventTime.ToLongTimeString()} {appEvent.EventTime.ToShortDateString()} | {appEvent.Level} | {appEvent.Message}");
                }
                //writer.WriteLine($"{appEvent.EventTime.ToLongTimeString()} {appEvent.EventTime.ToLongDateString()} | {appEvent.Level} | {appEvent.Message}");
            }
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