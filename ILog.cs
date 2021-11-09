// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php

namespace Logg
{
    // todo: implement LoggerFactory and all the other required classes

    // The logger interface. 
    // Any class that needs a logger should use this abstraction.
    public interface ILog
    {
        void Debug(string message);
        void Info(string message);
        void Warning(string message);
        void Error(string message);
    }
}