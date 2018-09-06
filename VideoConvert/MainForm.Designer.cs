namespace VideoConvert
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputLabel = new System.Windows.Forms.Label();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.FormatComboBox = new System.Windows.Forms.ComboBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.InputPathPanel = new System.Windows.Forms.Panel();
            this.InputFolderRadioButton = new System.Windows.Forms.RadioButton();
            this.InputFileRadioButton = new System.Windows.Forms.RadioButton();
            this.ConvertProgressLabel = new System.Windows.Forms.Label();
            this.ConvertProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressValueLabel = new System.Windows.Forms.Label();
            this.ConvertPanel = new System.Windows.Forms.Panel();
            this.FormatPanel = new System.Windows.Forms.Panel();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.Inputpanel = new System.Windows.Forms.Panel();
            this.InputPathPanel.SuspendLayout();
            this.ConvertPanel.SuspendLayout();
            this.FormatPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.Inputpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.InputLabel.Location = new System.Drawing.Point(10, 10);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(174, 50);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "输入路径";
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.FormatLabel.Location = new System.Drawing.Point(10, 25);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(174, 50);
            this.FormatLabel.TabIndex = 1;
            this.FormatLabel.Text = "输出格式";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("新宋体", 12F);
            this.InputTextBox.Location = new System.Drawing.Point(200, 10);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(650, 44);
            this.InputTextBox.TabIndex = 0;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("新宋体", 12F);
            this.OutputTextBox.Location = new System.Drawing.Point(200, 35);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(650, 44);
            this.OutputTextBox.TabIndex = 4;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.OutputLabel.Location = new System.Drawing.Point(10, 25);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(174, 50);
            this.OutputLabel.TabIndex = 4;
            this.OutputLabel.Text = "输出路径";
            // 
            // FormatComboBox
            // 
            this.FormatComboBox.Font = new System.Drawing.Font("新宋体", 12F);
            this.FormatComboBox.FormattingEnabled = true;
            this.FormatComboBox.Items.AddRange(new object[] {
            "3gp",
            "asf",
            "asx",
            "avi",
            "dat",
            "flv",
            "m4v",
            "mkv",
            "mov",
            "mp4",
            "mpe",
            "mpeg",
            "mpg",
            "rm",
            "rmvb",
            "vob",
            "wmv"});
            this.FormatComboBox.Location = new System.Drawing.Point(200, 35);
            this.FormatComboBox.Name = "FormatComboBox";
            this.FormatComboBox.Size = new System.Drawing.Size(650, 41);
            this.FormatComboBox.Sorted = true;
            this.FormatComboBox.TabIndex = 6;
            // 
            // InputButton
            // 
            this.InputButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.InputButton.Location = new System.Drawing.Point(880, 10);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(100, 55);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = "";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.OutputButton.Location = new System.Drawing.Point(880, 30);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(100, 55);
            this.OutputButton.TabIndex = 5;
            this.OutputButton.Text = "";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.ConvertButton.Location = new System.Drawing.Point(880, 30);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(100, 55);
            this.ConvertButton.TabIndex = 7;
            this.ConvertButton.Text = "";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // InputPathPanel
            // 
            this.InputPathPanel.Controls.Add(this.InputFolderRadioButton);
            this.InputPathPanel.Controls.Add(this.InputFileRadioButton);
            this.InputPathPanel.Location = new System.Drawing.Point(200, 100);
            this.InputPathPanel.Name = "InputPathPanel";
            this.InputPathPanel.Size = new System.Drawing.Size(650, 80);
            this.InputPathPanel.TabIndex = 13;
            // 
            // InputFolderRadioButton
            // 
            this.InputFolderRadioButton.AllowDrop = true;
            this.InputFolderRadioButton.AutoSize = true;
            this.InputFolderRadioButton.Location = new System.Drawing.Point(320, 13);
            this.InputFolderRadioButton.Name = "InputFolderRadioButton";
            this.InputFolderRadioButton.Size = new System.Drawing.Size(319, 54);
            this.InputFolderRadioButton.TabIndex = 3;
            this.InputFolderRadioButton.TabStop = true;
            this.InputFolderRadioButton.Text = "选择视频文件夹";
            this.InputFolderRadioButton.UseVisualStyleBackColor = true;
            this.InputFolderRadioButton.CheckedChanged += new System.EventHandler(this.InputFolderRadioButton_CheckedChanged);
            // 
            // InputFileRadioButton
            // 
            this.InputFileRadioButton.AutoSize = true;
            this.InputFileRadioButton.Checked = true;
            this.InputFileRadioButton.Location = new System.Drawing.Point(10, 13);
            this.InputFileRadioButton.Name = "InputFileRadioButton";
            this.InputFileRadioButton.Size = new System.Drawing.Size(281, 54);
            this.InputFileRadioButton.TabIndex = 2;
            this.InputFileRadioButton.TabStop = true;
            this.InputFileRadioButton.Text = "选择视频文件";
            this.InputFileRadioButton.UseVisualStyleBackColor = true;
            this.InputFileRadioButton.CheckedChanged += new System.EventHandler(this.InputFileRadioButton_CheckedChanged);
            // 
            // ConvertProgressLabel
            // 
            this.ConvertProgressLabel.AutoSize = true;
            this.ConvertProgressLabel.Location = new System.Drawing.Point(10, 25);
            this.ConvertProgressLabel.Name = "ConvertProgressLabel";
            this.ConvertProgressLabel.Size = new System.Drawing.Size(174, 50);
            this.ConvertProgressLabel.TabIndex = 15;
            this.ConvertProgressLabel.Text = "转换进度";
            // 
            // ConvertProgressBar
            // 
            this.ConvertProgressBar.Location = new System.Drawing.Point(200, 35);
            this.ConvertProgressBar.Name = "ConvertProgressBar";
            this.ConvertProgressBar.Size = new System.Drawing.Size(650, 30);
            this.ConvertProgressBar.TabIndex = 16;
            // 
            // ProgressValueLabel
            // 
            this.ProgressValueLabel.AutoSize = true;
            this.ProgressValueLabel.Location = new System.Drawing.Point(870, 25);
            this.ProgressValueLabel.Name = "ProgressValueLabel";
            this.ProgressValueLabel.Size = new System.Drawing.Size(33, 50);
            this.ProgressValueLabel.TabIndex = 18;
            this.ProgressValueLabel.Text = " ";
            // 
            // ConvertPanel
            // 
            this.ConvertPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConvertPanel.Controls.Add(this.ConvertProgressLabel);
            this.ConvertPanel.Controls.Add(this.ProgressValueLabel);
            this.ConvertPanel.Controls.Add(this.ConvertProgressBar);
            this.ConvertPanel.Location = new System.Drawing.Point(30, 600);
            this.ConvertPanel.Name = "ConvertPanel";
            this.ConvertPanel.Size = new System.Drawing.Size(1000, 100);
            this.ConvertPanel.TabIndex = 19;
            // 
            // FormatPanel
            // 
            this.FormatPanel.Controls.Add(this.FormatLabel);
            this.FormatPanel.Controls.Add(this.FormatComboBox);
            this.FormatPanel.Controls.Add(this.ConvertButton);
            this.FormatPanel.Location = new System.Drawing.Point(30, 450);
            this.FormatPanel.Name = "FormatPanel";
            this.FormatPanel.Size = new System.Drawing.Size(1000, 100);
            this.FormatPanel.TabIndex = 20;
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.OutputLabel);
            this.OutputPanel.Controls.Add(this.OutputTextBox);
            this.OutputPanel.Controls.Add(this.OutputButton);
            this.OutputPanel.Location = new System.Drawing.Point(30, 300);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(1000, 100);
            this.OutputPanel.TabIndex = 21;
            // 
            // Inputpanel
            // 
            this.Inputpanel.Controls.Add(this.InputLabel);
            this.Inputpanel.Controls.Add(this.InputTextBox);
            this.Inputpanel.Controls.Add(this.InputButton);
            this.Inputpanel.Controls.Add(this.InputPathPanel);
            this.Inputpanel.Location = new System.Drawing.Point(30, 50);
            this.Inputpanel.Name = "Inputpanel";
            this.Inputpanel.Size = new System.Drawing.Size(1000, 200);
            this.Inputpanel.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1074, 729);
            this.Controls.Add(this.Inputpanel);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.FormatPanel);
            this.Controls.Add(this.ConvertPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoConvert";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.InputPathPanel.ResumeLayout(false);
            this.InputPathPanel.PerformLayout();
            this.ConvertPanel.ResumeLayout(false);
            this.ConvertPanel.PerformLayout();
            this.FormatPanel.ResumeLayout(false);
            this.FormatPanel.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            this.Inputpanel.ResumeLayout(false);
            this.Inputpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.ComboBox FormatComboBox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button OutputButton;
        protected System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Panel InputPathPanel;
        private System.Windows.Forms.RadioButton InputFolderRadioButton;
        private System.Windows.Forms.RadioButton InputFileRadioButton;
        private System.Windows.Forms.Label ConvertProgressLabel;
        private System.Windows.Forms.ProgressBar ConvertProgressBar;
        private System.Windows.Forms.Label ProgressValueLabel;
        private System.Windows.Forms.Panel ConvertPanel;
        private System.Windows.Forms.Panel FormatPanel;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Panel Inputpanel;
    }
}

