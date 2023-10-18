using Services.Abstract;
using NLog;


namespace Services.Concrete
{
    public class LoggerManager : ILoggerService
    {
        private static ILogger logger= LogManager.GetCurrentClassLogger();
        public void LogDebug(string message)=> logger.Debug(message);

        public void LogError(string message)=> logger.Error(message);

        public void LogInfo(string message)=>logger.Info(message);

        public void LogWarnnig(string message)=> logger.Warn(message);
    }
}
