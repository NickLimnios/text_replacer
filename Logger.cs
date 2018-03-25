using System;
using System.IO;
using log4net;
using System.Windows.Forms;

namespace TextReplacer
{
    public class Logger : ILogger 
    {

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly TextBox tbLog;

        public Logger(TextBox TbLog)
        {
            tbLog = TbLog;
        }

        public void AddLogEntry(string message, LogEntryLevel logEntryLevel)
        {
            AddLogEntry(message, logEntryLevel, null);
        }

        public void AddLogEntry(string message, LogEntryLevel logEntryLevel, Exception ex)
        {
            switch (logEntryLevel)
            {
                case LogEntryLevel.Info:
                    log.Info(message);
                    break;
                case LogEntryLevel.Warning:
                    log.Warn(message);
                    break;
                case LogEntryLevel.Error:
                    if (ex == null)
                        log.Error(message);
                    else
                        log.Error(message, ex);
                    break;
                default:
                    break;
            }

            AppendText(message);
        }

        public void AppendText(string s)
        {
            if (tbLog.InvokeRequired)
            {
                tbLog.Invoke(new MethodInvoker(delegate () { AppendText(s); }));
            }
            else
            {
                DateTime timestamp = DateTime.Now;
                tbLog.AppendText(timestamp.ToShortTimeString() + "\t" + s + Environment.NewLine);
            }
        }
    }
}
