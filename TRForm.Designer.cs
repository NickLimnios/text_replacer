namespace TextReplacer
{
    partial class TRForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRForm));
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.gbMultiFileEditor = new System.Windows.Forms.GroupBox();
            this.btnCounter = new System.Windows.Forms.Button();
            this.cbReplaceEmpty = new System.Windows.Forms.CheckBox();
            this.lbAllowReplaceEmpty = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFileExt = new System.Windows.Forms.ComboBox();
            this.tbReplaceText = new System.Windows.Forms.TextBox();
            this.tbFindText = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lbReplaceControl = new System.Windows.Forms.Label();
            this.cbReplaceControl = new System.Windows.Forms.CheckBox();
            this.lblReplaceText = new System.Windows.Forms.Label();
            this.lblFindText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbP1 = new System.Windows.Forms.TabPage();
            this.tbP2 = new System.Windows.Forms.TabPage();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbMultiFileEditor.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbP1.SuspendLayout();
            this.tbP2.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(272, 241);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(30, 40);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(83, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Enter Directory :";
            this.toolTip1.SetToolTip(this.lblPath, "Text Replacer will search in the folders and \r\nsubfolders of this directory for t" +
        "he selected file type.");
            // 
            // gbMultiFileEditor
            // 
            this.gbMultiFileEditor.Controls.Add(this.btnCounter);
            this.gbMultiFileEditor.Controls.Add(this.cbReplaceEmpty);
            this.gbMultiFileEditor.Controls.Add(this.lbAllowReplaceEmpty);
            this.gbMultiFileEditor.Controls.Add(this.btnExecute);
            this.gbMultiFileEditor.Controls.Add(this.btnBrowser);
            this.gbMultiFileEditor.Controls.Add(this.label1);
            this.gbMultiFileEditor.Controls.Add(this.cbFileExt);
            this.gbMultiFileEditor.Controls.Add(this.tbReplaceText);
            this.gbMultiFileEditor.Controls.Add(this.tbFindText);
            this.gbMultiFileEditor.Controls.Add(this.tbFilePath);
            this.gbMultiFileEditor.Controls.Add(this.lbReplaceControl);
            this.gbMultiFileEditor.Controls.Add(this.cbReplaceControl);
            this.gbMultiFileEditor.Controls.Add(this.lblReplaceText);
            this.gbMultiFileEditor.Controls.Add(this.lblFindText);
            this.gbMultiFileEditor.Controls.Add(this.lblPath);
            this.gbMultiFileEditor.Controls.Add(this.groupBox1);
            this.gbMultiFileEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMultiFileEditor.Location = new System.Drawing.Point(3, 3);
            this.gbMultiFileEditor.Name = "gbMultiFileEditor";
            this.gbMultiFileEditor.Size = new System.Drawing.Size(370, 280);
            this.gbMultiFileEditor.TabIndex = 5;
            this.gbMultiFileEditor.TabStop = false;
            // 
            // btnCounter
            // 
            this.btnCounter.Location = new System.Drawing.Point(23, 241);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(75, 23);
            this.btnCounter.TabIndex = 17;
            this.btnCounter.Text = "Counter";
            this.toolTip1.SetToolTip(this.btnCounter, "Count the number of files of the chosen extension,\r\nin the selected directory fol" +
        "ders and subfolders.");
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // cbReplaceEmpty
            // 
            this.cbReplaceEmpty.AutoSize = true;
            this.cbReplaceEmpty.Location = new System.Drawing.Point(119, 205);
            this.cbReplaceEmpty.Name = "cbReplaceEmpty";
            this.cbReplaceEmpty.Size = new System.Drawing.Size(15, 14);
            this.cbReplaceEmpty.TabIndex = 16;
            this.cbReplaceEmpty.UseVisualStyleBackColor = true;
            // 
            // lbAllowReplaceEmpty
            // 
            this.lbAllowReplaceEmpty.AutoSize = true;
            this.lbAllowReplaceEmpty.Location = new System.Drawing.Point(28, 205);
            this.lbAllowReplaceEmpty.Name = "lbAllowReplaceEmpty";
            this.lbAllowReplaceEmpty.Size = new System.Drawing.Size(85, 13);
            this.lbAllowReplaceEmpty.TabIndex = 15;
            this.lbAllowReplaceEmpty.Text = "Replace Empty :";
            this.toolTip1.SetToolTip(this.lbAllowReplaceEmpty, "Check if you want to allow Replace Text \r\nfield to be empty.");
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(314, 40);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(25, 20);
            this.btnBrowser.TabIndex = 14;
            this.btnBrowser.Text = "...";
            this.btnBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "File Extension :";
            this.toolTip1.SetToolTip(this.label1, "Choose the type of files to edit.");
            // 
            // cbFileExt
            // 
            this.cbFileExt.FormattingEnabled = true;
            this.cbFileExt.Items.AddRange(new object[] {
            ".txt",
            ".csv",
            ".bat",
            ".csproj"});
            this.cbFileExt.Location = new System.Drawing.Point(119, 144);
            this.cbFileExt.Name = "cbFileExt";
            this.cbFileExt.Size = new System.Drawing.Size(80, 21);
            this.cbFileExt.TabIndex = 12;
            // 
            // tbReplaceText
            // 
            this.tbReplaceText.Location = new System.Drawing.Point(119, 111);
            this.tbReplaceText.Name = "tbReplaceText";
            this.tbReplaceText.Size = new System.Drawing.Size(220, 20);
            this.tbReplaceText.TabIndex = 11;
            // 
            // tbFindText
            // 
            this.tbFindText.Location = new System.Drawing.Point(119, 77);
            this.tbFindText.Name = "tbFindText";
            this.tbFindText.Size = new System.Drawing.Size(220, 20);
            this.tbFindText.TabIndex = 10;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(119, 40);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(220, 20);
            this.tbFilePath.TabIndex = 9;
            // 
            // lbReplaceControl
            // 
            this.lbReplaceControl.AutoSize = true;
            this.lbReplaceControl.Location = new System.Drawing.Point(24, 179);
            this.lbReplaceControl.Name = "lbReplaceControl";
            this.lbReplaceControl.Size = new System.Drawing.Size(89, 13);
            this.lbReplaceControl.TabIndex = 8;
            this.lbReplaceControl.Text = "Replace Control :";
            this.toolTip1.SetToolTip(this.lbReplaceControl, "Uncheck if you want to allow the replacement,\r\nwhen the replace text already exis" +
        "ts in the content.");
            // 
            // cbReplaceControl
            // 
            this.cbReplaceControl.AutoSize = true;
            this.cbReplaceControl.Checked = true;
            this.cbReplaceControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReplaceControl.Location = new System.Drawing.Point(119, 179);
            this.cbReplaceControl.Name = "cbReplaceControl";
            this.cbReplaceControl.Size = new System.Drawing.Size(15, 14);
            this.cbReplaceControl.TabIndex = 7;
            this.cbReplaceControl.UseVisualStyleBackColor = true;
            // 
            // lblReplaceText
            // 
            this.lblReplaceText.AutoSize = true;
            this.lblReplaceText.Location = new System.Drawing.Point(36, 111);
            this.lblReplaceText.Name = "lblReplaceText";
            this.lblReplaceText.Size = new System.Drawing.Size(77, 13);
            this.lblReplaceText.TabIndex = 6;
            this.lblReplaceText.Text = "Replace Text :";
            this.toolTip1.SetToolTip(this.lblReplaceText, "Enter the new text. If you want to be empty\r\ncheck the Replace Empty box and unch" +
        "eck the Replace Control.");
            // 
            // lblFindText
            // 
            this.lblFindText.AutoSize = true;
            this.lblFindText.Location = new System.Drawing.Point(56, 77);
            this.lblFindText.Name = "lblFindText";
            this.lblFindText.Size = new System.Drawing.Size(57, 13);
            this.lblFindText.TabIndex = 5;
            this.lblFindText.Text = "Find Text :";
            this.toolTip1.SetToolTip(this.lblFindText, "Enter the text to be replaced.");
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 216);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbP1);
            this.tbcMain.Controls.Add(this.tbP2);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(384, 312);
            this.tbcMain.TabIndex = 13;
            // 
            // tbP1
            // 
            this.tbP1.Controls.Add(this.gbMultiFileEditor);
            this.tbP1.Location = new System.Drawing.Point(4, 22);
            this.tbP1.Name = "tbP1";
            this.tbP1.Padding = new System.Windows.Forms.Padding(3);
            this.tbP1.Size = new System.Drawing.Size(376, 286);
            this.tbP1.TabIndex = 0;
            this.tbP1.Text = "Main";
            this.tbP1.UseVisualStyleBackColor = true;
            // 
            // tbP2
            // 
            this.tbP2.Controls.Add(this.gbLog);
            this.tbP2.Location = new System.Drawing.Point(4, 22);
            this.tbP2.Name = "tbP2";
            this.tbP2.Padding = new System.Windows.Forms.Padding(3);
            this.tbP2.Size = new System.Drawing.Size(376, 286);
            this.tbP2.TabIndex = 1;
            this.tbP2.Text = "Log";
            this.tbP2.UseVisualStyleBackColor = true;
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.tbLog);
            this.gbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLog.Location = new System.Drawing.Point(3, 3);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(370, 280);
            this.gbLog.TabIndex = 0;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Info";
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(3, 16);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(364, 261);
            this.tbLog.TabIndex = 0;
            this.tbLog.TextChanged += new System.EventHandler(this.tbLog_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.Controls.Add(this.tbcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.gbMultiFileEditor.ResumeLayout(false);
            this.gbMultiFileEditor.PerformLayout();
            this.tbcMain.ResumeLayout(false);
            this.tbP1.ResumeLayout(false);
            this.tbP2.ResumeLayout(false);
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.GroupBox gbMultiFileEditor;
        private System.Windows.Forms.Label lblReplaceText;
        private System.Windows.Forms.Label lblFindText;
        private System.Windows.Forms.Label lbReplaceControl;
        private System.Windows.Forms.CheckBox cbReplaceControl;
        private System.Windows.Forms.TextBox tbReplaceText;
        private System.Windows.Forms.TextBox tbFindText;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.ComboBox cbFileExt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbP1;
        private System.Windows.Forms.TabPage tbP2;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.CheckBox cbReplaceEmpty;
        private System.Windows.Forms.Label lbAllowReplaceEmpty;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.GroupBox groupBox1;


    }
}

