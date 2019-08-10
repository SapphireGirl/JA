using System;
using log4net;
using WebGrease;

namespace JA.Logging.Models
{
    // In Staging/Development: Set Log Level Minimum to DEBUG
    // In Production: Set Log Level Minimum to WARN
    // ALL    DEBUG   INFO     WARN   ERROR   FATAL   OFF
    //•All                        
    //•DEBUG  •DEBUG                  
    //•INFO   •INFO   •INFO               
    //•WARN   •WARN   •WARN   •WARN           
    //•ERROR  •ERROR  •ERROR  •ERROR  •ERROR      
    //•FATAL  •FATAL  •FATAL  •FATAL  •FATAL  •FATAL  
    //•OFF    •OFF    •OFF    •OFF    •OFF    •OFF    •OFF
    public class LoggerBase : IDisposable
    {

        //public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected static readonly log4net.ILog log
            = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private bool _isDebugEnabled;

        public LoggerBase()
        {
            LogSetup();
        }
        private void LogSetup()
        {
            //XmlConfigurator.Configure();
            _isDebugEnabled = log.IsDebugEnabled;
        }
        public bool GetIsDebugEnabled()
        {
            return _isDebugEnabled;
        }
        public virtual void WriteToDebugLog(string callingClass, string message)
        {
            log.Debug($"{DateTime.Now}: {callingClass}: {message}");
        }
        public virtual void WriteToInfoLog(string callingClass, string message)
        {
            log.Info($"{DateTime.Now}: {callingClass}: {message}");
        }
        public virtual void WriteToWarningLog(string callingClass, string message)
        {
            log.Warn($"{DateTime.Now}: {callingClass}: {message}");
        }
        public virtual void WriteToErrorLog(string callingClass, string message)
        {
            log.Error($"{DateTime.Now}: {callingClass}: {message}");
        }
        public virtual void WriteToFatalLog(string callingClass, string message)
        {
            log.Fatal($"{DateTime.Now}: {callingClass}: {message}");
        }
        public virtual void WriteToConsole(string callingClass, string message)
        {
             Console.WriteLine("Class: {0}, Message: {1} ", callingClass, message);
        }
        public virtual string GetLogFileName()
        {
            string filename = null;

            //IAppender[] appenders = log.Logger.Repository.GetAppenders();
            //// Check each appender this logger has
            //foreach (IAppender appender in appenders)
            //{
            //    Type t = appender.GetType();
            //    // Get the file name from the first FileAppender found and return
            //    if (t.Equals(typeof(FileAppender)) || t.Equals(typeof(RollingFileAppender)))
            //    {
            //        filename = ((FileAppender)appender).File;
            //        break;
            //    }
            //}
            return filename;
        }
        // TODO: Need to implement: check https://sourceforge.net/projects/log4net-json/
        public virtual void WriteJsonObjectToLog()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
        }
    }
}