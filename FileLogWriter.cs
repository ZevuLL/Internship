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
            }
        }
    }
}