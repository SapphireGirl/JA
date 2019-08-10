using System;

namespace JA.Logging.Models
{
    public class TraceLogger : LoggerBase
    {
        // TODO: Error/Warning should write to a different log
        
        public TraceLogger()
        {
            //XmlConfigurator.Configure();
        }
        public override void WriteToDebugLog(string callingClass, string message)
        {
            log.Debug($"{DateTime.Now}: {callingClass}: {message}");
            WriteToConsole(callingClass, message);
        }
        
    }
}