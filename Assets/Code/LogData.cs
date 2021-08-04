using UnityEngine;

namespace Code
{
    internal class LogData
    {
        public readonly string LogString;
        public readonly string StackTrace;
        public readonly LogType Type;

        public LogData(string logString, string stackTrace, LogType type)
        {
            this.LogString = logString;
            this.StackTrace = stackTrace;
            this.Type = type;
        }
    }
}