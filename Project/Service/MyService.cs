// паттерн Стратегия https://metanit.com/sharp/patterns/3.1.php
using System;


namespace Logg
{
    public class MyService
    {
        private readonly ILog logger;

        public MyService(ILog logger)
        {
            this.logger = logger;
        }

        public void MyMethod()
        {
            logger.Debug("Debug message sample.");
            logger.Info("Info message sample.");
            logger.Warning("Warning message sample.");
            logger.Error("Error message sample.");

            try
            {
                throw new Exception("exception text");
            }
            catch (Exception ex)
            {
                logger.Error($"Error: {ex}");
            }

        }
    }
}