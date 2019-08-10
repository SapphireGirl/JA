namespace JA.Logging.Models
{
    public interface ILogger
    {
        bool GetIsDebugEnabled();
        void WriteToLogFile(string callingFunction, string message);
        void ConsoleLog(string application, string message);
        void WriteEntry(string message, string type, string module);
    }
}
