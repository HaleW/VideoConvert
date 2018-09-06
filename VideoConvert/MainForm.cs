using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VideoConvert.Properties;

namespace VideoConvert
{
    public partial class MainForm : Form
    {
        private bool RadioButtonCheckState = true;
        private int TotalTimeValue = 0;
        private int ConvertTimeValue = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (RadioButtonCheckState)
            {
                OpenFileDialog InputOFD = new OpenFileDialog
                {
                    Filter =
                    "视频文件|" +
                    "*.wmv;*.asf;*.asx;*.rm;*.rmvb;" +
                    "*.mpg;*.mpeg;*.mpe;*.3gp;*.mov;*.mp4;" +
                    "*.m4v;*.avi;*.datZ;*.mkv;*.flv;*.vob|" +
                    "所有文件|*.*"
                };

                if (InputOFD.ShowDialog() == DialogResult.OK)
                {
                    InputTextBox.Text = InputOFD.FileName;
                }
            }
            else
            {
                FolderBrowserDialog InputFBD = new FolderBrowserDialog();
                if (InputFBD.ShowDialog() == DialogResult.OK)
                {
                    InputTextBox.Text = InputFBD.SelectedPath;
                }
            }

        }

        private void InputFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InputFileRadioButton.Checked)
            {
                RadioButtonCheckState = true;
            }
        }

        private void InputFolderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InputFolderRadioButton.Checked)
            {
                RadioButtonCheckState = false;
            }
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog OutputFBD = new FolderBrowserDialog();
            if (OutputFBD.ShowDialog() == DialogResult.OK)
            {
                OutputTextBox.Text = OutputFBD.SelectedPath;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string SourceFile = InputTextBox.Text;
            string ConvertFile = OutputTextBox.Text;
            string FileName = Path.GetFileNameWithoutExtension(InputTextBox.Text);
            string Format = FormatComboBox.SelectedItem.ToString();

            string FFmpegPath = @".\ffmpeg.exe";                
            string arg = " -i " + SourceFile + " -c copy " + ConvertFile + @"\" + FileName + "." + Format;
            Process process = new Process();
            process.StartInfo.FileName = FFmpegPath;
            process.StartInfo.Arguments = arg;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.BeginErrorReadLine();
            process.ErrorDataReceived += new DataReceivedEventHandler(Output);
            process.OutputDataReceived += new DataReceivedEventHandler(Output);
            if (!process.HasExited)
            {
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(20);
            }
            process.Close();
        }
        private void Output(object sendProcess, DataReceivedEventArgs output)
        {

            if (!String.IsNullOrEmpty(output.Data))
            {
                string FileIsExist = "already exists.";
                Regex regex = new Regex(FileIsExist);
                if (regex.IsMatch(output.Data))
                {
                    MessageBox.Show("已存在与输出文件的同名文件！", "提示");
                }

                string InvalidArgument = "Invalid argument";
                Regex reg = new Regex(InvalidArgument);
                if(reg.IsMatch(output.Data))
                {
                    MessageBox.Show("不支持转换为" + FormatComboBox.SelectedItem.ToString() + "格式", "提示");
                }
                string TotalTime = @"Duration: \d{2}:\d{2}:\d{2}.\d{2}";
                int TotalTimeTemp= GetTime(TotalTime, output.Data, 10, 8);
                if (TotalTimeTemp != 0)
                {
                    TotalTimeValue = TotalTimeTemp;
                }
                
                string ConvertTime = @"time=\d{2}:\d{2}:\d{2}.\d{2}";
                ConvertTimeValue = GetTime(ConvertTime, output.Data, 5, 8);

                if (TotalTimeValue > 1 && (ConvertTimeValue > 1 && ConvertTimeValue <= TotalTimeValue))
                {
                    double ProgressValue = Math.Round((double)(TotalTimeValue - ConvertTimeValue) / TotalTimeValue, 2) * 100;
                    ConvertProgressBar.Value = ConvertProgressBar.Maximum-(int)ProgressValue;
                    ConvertProgressBar.Step = (int)ProgressValue;
                    ProgressValueLabel.Text = (ConvertProgressBar.Maximum - (int)ProgressValue).ToString() + "%";
                }
            }
        }

        private int GetTime(string RegexString, string TimeString, int StartIndex, int Length)
        {
            Regex regex = new Regex(RegexString);
            int TimeValue = 0;
            if (regex.IsMatch(TimeString))
            {
                string TimeStr = regex.Match(TimeString).Value;
                string[] TimeValues = TimeStr.Substring(StartIndex, Length).Split(':');
                int Hours = Convert.ToInt32(TimeValues[0]);
                int Minutes = Convert.ToInt32(TimeValues[1]);
                int Seconds = Convert.ToInt32(TimeValues[2]);
                TimeValue = Hours * 60 * 60 + Minutes * 60 + Seconds;
            }
            return TimeValue;
        }
    }
}
