using System;
using System.IO;
using System.Linq;
using System.Text;

namespace TextReplacer
{
    public class Editor
    {
        private ILogger log;

        public Editor(ILogger logger)
        {
            log = logger;
        }

        public string CountFiles(string path, string fileExt, SearchOption searchOption)
        {
            string[] arr = Directory.GetFiles(path, "*" + fileExt, searchOption);

            var egrp = arr.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                .GroupBy(x => x, (ext, extCnt) => new
                {
                    Extension = ext,
                    Count = extCnt.Count()
                });

            StringBuilder sb = new StringBuilder();
            foreach (var v in egrp)
                    sb.AppendLine(String.Format(Resources.infoCountFiles,v.Count,fileExt));

            string result = sb.Length == 0 ? String.Format(Resources.infoZeroCountFiles,fileExt) : sb.ToString();
            log.AddLogEntry(result, LogEntryLevel.Info);

            return result;
        }

        public string Replace(string path, string searchPattern, string currentText, string newText, bool replaceControl)
        {
            string result = String.Empty;
            try
            {
                log.AddLogEntry(Resources.infoReplaceStarted, LogEntryLevel.Info);
                int counter = 0;

                foreach (string file in Directory.GetFiles(path, searchPattern, SearchOption.AllDirectories))
                {
                    string content = GetContent(file);
                    if (content.Contains(currentText))
                    {
                        if (replaceControl == false || (replaceControl == true && !content.Contains(newText)))
                        {
                            content = content.Replace(currentText, newText);
                            WriteContent(file, content);
                            counter = counter + 1;
                            log.AddLogEntry(String.Format(Resources.infoOpenFile, file), LogEntryLevel.Info);
                            log.AddLogEntry(String.Format(Resources.infoReplaceValue, currentText, newText), LogEntryLevel.Info);
                            log.AddLogEntry(String.Format(Resources.infoCloseFile, file), LogEntryLevel.Info);
                        }
                        else if (replaceControl == true && content.Contains(newText))
                        {
                            log.AddLogEntry(String.Format(Resources.wrnTextExists, file, newText), LogEntryLevel.Warning);
                        }
                    }
                }

                result = String.Format(Resources.infoReplaceEnded, counter);
                log.AddLogEntry(result, LogEntryLevel.Info);
            }
            catch (Exception ex)
            {
                log.AddLogEntry(ex.Message, LogEntryLevel.Error, ex);
            }
   
            return result;
        }

        private string GetContent(string file)
        {
            string content = String.Empty;
            using (StreamReader reader = new StreamReader(file))
            {
                content = reader.ReadToEnd();
                reader.Close();
            }

            return content;
        }

        private void WriteContent(string file, string content)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(content);
                writer.Close();
            }
        }
    }
}
