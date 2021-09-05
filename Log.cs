using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WarehouseAccounting
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            FontColor();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtfLog.Text);
            MessageBox.Show("Лог скопирован в буфер обмена!");
        }

        private void BClear_Click(object sender, EventArgs e)
        {

        }

        private void BSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "Текстовый файл (*.txt)|*.txt|Лог файл(*.log)|*.log|RTF документ|.rtf";
            sFD.InitialDirectory = @"C:\";
            sFD.RestoreDirectory = true;
            sFD.FilterIndex = 2;
            sFD.Title = "Сохранение журнала";
            sFD.DefaultExt = "txt";
            // sFD.CheckFileExists = true;
            sFD.CheckPathExists = true;

            if (sFD.ShowDialog() == DialogResult.OK)
            {
                switch (sFD.FilterIndex)
                {
                    case 0:
                        File.WriteAllText(sFD.FileName, rtfLog.Text);
                        break;
                    case 1:
                        File.WriteAllText(sFD.FileName, rtfLog.Text);
                        break;
                    case 2:
                        rtfLog.SaveFile(sFD.FileName,RichTextBoxStreamType.RichText);
                        break;
                    default:
                        File.WriteAllText(sFD.FileName, rtfLog.Text);
                        break;

                }
            }
        }

        private void Log_Load(object sender, EventArgs e)
        {
            int WHeight = 0, WWidth = 0;
            WHeight = Screen.PrimaryScreen.Bounds.Size.Height;
            WWidth = Screen.PrimaryScreen.Bounds.Size.Width;
            FontColor();
        }

        public int getColorString(string text)
        {
            if (text.IndexOf("Ошибка") > -1)
            {
                return 0;
            }
            else if (text.IndexOf("Предупреждение") > -1)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public string getCurrentString(int index)
        {
            return rtfLog.Lines[index];
        }

        public void SaveLog(bool isExit)
        {
            try
            {
                if (File.Exists(Program.st.curdir + "\\blackbox.log"))
                {
                    File.AppendAllText(Program.st.curdir + "\\blackbox.log", Environment.NewLine + Environment.NewLine + rtfLog.Text, Encoding.Default);
                }
                else
                {
                    File.WriteAllText(Program.st.curdir + "\\blackbox.log", Environment.NewLine + Environment.NewLine + rtfLog.Text, Encoding.Default);
                }

                if (File.Exists(Program.st.curdir + "\\current-" + DateTime.Now + ".log"))
                {
                    File.AppendAllText(Program.st.curdir + "\\current-" + DateTime.Now + ".log", Environment.NewLine + Environment.NewLine + rtfLog.Text, Encoding.Default);
                }
                else
                {
                    File.WriteAllText(Program.st.curdir + "\\current-" + DateTime.Now + ".log", Environment.NewLine + Environment.NewLine + rtfLog.Text, Encoding.Default);
                }

            }
            catch
            {
                if (isExit)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Невозможно сохранить журнал на диск!", "Ошибка сохранения журнала!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string getEndOfLine(string action)
        {
            switch (action)
            {
                case "retry": return "(Попытка снова)";
                case "abort": return "(Прерывание операции)";
                case "ok": return ("ОК!");
                case "continue": return "(Продолжаем)";
                case "kernel panic": return "(Kernel Panic)";
                case "miss": return "(Пропуск операции)";
                case "hang": return ("Приложение не отвечает");
                case "bypass": return ("Обход ошибки");
                default: return "(Неизвестная ошибка)";
            }
        }

        public void setToLog(string prefix,int code, string snls, string phrase, string action)
        {
            switch (code)
            {
                case 0:
                    rtfLog.Text += DateTime.Now + " Ошибка в " + prefix + "! [Код:" + snls + "] " + phrase + ". Действие: " + getEndOfLine(action) + Environment.NewLine;
                    break;
                     
                case 1:
                    rtfLog.Text += DateTime.Now + " Предупреждение в " + prefix + "! [Код:" + snls + "] " + phrase + ". Действие: " + getEndOfLine(action) + Environment.NewLine;
                    break;

                case 2:
                    rtfLog.Text += DateTime.Now + " Сообщение" + prefix + "! [Код:" + snls + "] " + phrase + ". Действие: " + getEndOfLine(action) + Environment.NewLine;
                    break;

                default:
                    rtfLog.Text += DateTime.Now + " Сообщение" + prefix + "! [Код:" + snls + "] " + phrase + ". Действие: " + getEndOfLine(action) + Environment.NewLine;
                    break;
            }
        }

        public void FontColor()
        {
            int start = 0; int end = 0;
            if (rtfLog.TextLength <=0)
            {
                return;
            }
            else
            {
                end = rtfLog.Lines[0].Length;
            }
            rtfLog.Select(start, end);
            if (getColorString(getCurrentString(0)) == 0)
            {
                rtfLog.SelectionColor = Color.Red;
            }
            else if (getColorString(getCurrentString(0)) == 1)
            {
                rtfLog.SelectionColor = Color.DarkCyan;
            }
            else
            {
                rtfLog.SelectionColor = Color.Blue;
            }

            for (int i = 1; i < rtfLog.Lines.Length - 1; i++)
            {

                start = end + 1;
                end = start + getCurrentString(i).Length;

                rtfLog.Select(start, end);

                if (getColorString(getCurrentString(i)) == 0)
                {
                    rtfLog.SelectionColor = Color.Red;
                }
                else if (getColorString(getCurrentString(i)) == 1)
                {
                    rtfLog.SelectionColor = Color.DarkCyan;
                }
                else
                {
                    rtfLog.SelectionColor = Color.Blue;
                }

            }

        }

    }
}
