using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TextReplacer
{
    public partial class TRForm : Form
    {
        public TRForm()
        {
            InitializeComponent();
        }

        public void EditAllFiles(string path, string findText, string replaceText, string fileExt, bool replaceControl)
        {
            try
            {
                int counter = 0;

                foreach (string file in Directory.GetFiles(path, "*"+fileExt, SearchOption.AllDirectories))
                {
                    var content = string.Empty;
                    using (StreamReader reader = new StreamReader(file))
                    {
                        content = reader.ReadToEnd();
                        reader.Close();
                    }

                    if (content.Contains(findText))
                    {
                        if (replaceControl == false || (replaceControl == true && !content.Contains(replaceText)))
                        {
                            content = content.Replace(findText, replaceText);
                            counter = counter + 1;

                            using (StreamWriter writer = new StreamWriter(file))
                            {
                                writer.Write(content);
                                writer.Close();
                            }
                            logger(" Edited file " + file + ". Old Value : " + findText + ", New Value : " + replaceText + ". ");
                        }
                        else if (replaceControl == true && content.Contains(replaceText))
                        {
                           logger(" Cannot edit file " + file + " because the replaced text : " + replaceText + " already exist in the content.");
                        }
                    }
                }
                MessageBox.Show("Operation Ended. " + counter + " files where edited.", "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger("Operation Ended. " + counter + " files where edited.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger(ex.Message);
            }
            }

        public bool validateFields(string path, string findText, string replaceText, string fileExt)
        {
            if (String.IsNullOrEmpty(path))
                return false;
            if (String.IsNullOrEmpty(findText))
                return false;
            if (!cbReplaceEmpty.Checked && String.IsNullOrEmpty(replaceText))
                return false;
            if (String.IsNullOrEmpty(fileExt))
                return false;
            else
                return true;    
        }

        public void logger(string logMessage)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.Write("{0} {1} : ", DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
                w.WriteLine(" {0}", logMessage);
            }
            AppendText(logMessage);
        }

        public void AppendText(string s)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate() { AppendText(s); }));
            }
            else
            {
                DateTime timestamp = DateTime.Now;
                tbLog.AppendText(timestamp.ToShortTimeString() + "\t" + s + Environment.NewLine);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string path = tbFilePath.Text;
            string findText = tbFindText.Text;
            string replaceText = tbReplaceText.Text;
            string fileExt = cbFileExt.Text;
            bool replaceControl = true;
            if (!cbReplaceControl.Checked)
                replaceControl = false;

            if (validateFields(path, findText, replaceText, fileExt))
            {
                using (StreamWriter w = File.CreateText("log.txt"))
                tbcMain.SelectTab(tbP2);
                AppendText("Operation Started.");
                EditAllFiles(path, findText, replaceText, fileExt, replaceControl);
            }
            else
                MessageBox.Show("Fields cannot be empty.", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tbLog_TextChanged(object sender, EventArgs e)
        {
            this.tbLog.ScrollBars = ScrollBars.Both;   
            this.tbLog.WordWrap = false;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserdlg = new FolderBrowserDialog();

            if (folderBrowserdlg.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = folderBrowserdlg.SelectedPath;
            }
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            string path = tbFilePath.Text;
            string fileExt = cbFileExt.Text ?? ".*";

            string[] arr = Directory.GetFiles(path, "*" + fileExt, SearchOption.AllDirectories);

            var egrp = arr.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                .GroupBy(x => x, (ext, extCnt) => new
                {
                    Extension = ext,
                    Count = extCnt.Count()
                });

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var v in egrp)
                sb.AppendLine(v.Count + " File(s) with " + v.Extension + " Extension found.");
            if (String.IsNullOrEmpty(sb.ToString()))
                MessageBox.Show(" 0 File(s) with " + fileExt + " Extension found.", "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(sb.ToString(), "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
