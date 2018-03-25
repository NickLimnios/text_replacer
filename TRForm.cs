using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace TextReplacer
{
    public partial class TRForm : Form
    {
        ILogger logger;
        Editor editor;

        public TRForm()
        {
            InitializeComponent();
            logger = new Logger(tbLog);
            editor = new Editor(logger);
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
               tbcMain.SelectTab(tbP2);
               string result = editor.Replace(path, "*" + fileExt, findText, replaceText, replaceControl);
               MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string result = editor.CountFiles(path, fileExt, SearchOption.AllDirectories);

            MessageBox.Show(result, "Count Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
        }
    }
}
