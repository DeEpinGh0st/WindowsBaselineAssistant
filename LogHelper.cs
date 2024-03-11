using System;

namespace WindowsBaselineAssistant
{
    public class LogHelper
    {
        //public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");
        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");
        public delegate void LogErrorEventHandler();
        public static event LogErrorEventHandler OnError;

        /*public static void WriteLog(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
            }
        }*/

        public static void WriteLog(string info, Exception ex)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info, ex);
                OnError?.Invoke();
            }
        }
    }
}
