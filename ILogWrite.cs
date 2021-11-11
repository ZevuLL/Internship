// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php

namespace Logg
{
    interface ILogWriter
    {
        void Write(AppEvent appEvent);
    }
}