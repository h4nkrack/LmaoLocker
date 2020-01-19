namespace LmaoLocker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iconBox = new System.Windows.Forms.TextBox();
            this.iconLabel = new System.Windows.Forms.Label();
            this.iconButton = new System.Windows.Forms.Button();
            this.iconImage = new System.Windows.Forms.PictureBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fileverBox = new System.Windows.Forms.TextBox();
            this.assFileVer = new System.Windows.Forms.Label();
            this.proverBox = new System.Windows.Forms.TextBox();
            this.assProVer = new System.Windows.Forms.Label();
            this.oriBox = new System.Windows.Forms.TextBox();
            this.assOri = new System.Windows.Forms.Label();
            this.tradeBox = new System.Windows.Forms.TextBox();
            this.assTrade = new System.Windows.Forms.Label();
            this.assCopy = new System.Windows.Forms.Label();
            this.assCom = new System.Windows.Forms.Label();
            this.assDes = new System.Windows.Forms.Label();
            this.assPro = new System.Windows.Forms.Label();
            this.assemblyLabel = new System.Windows.Forms.Label();
            this.copyBox = new System.Windows.Forms.TextBox();
            this.comBox = new System.Windows.Forms.TextBox();
            this.desBox = new System.Windows.Forms.TextBox();
            this.proBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buildButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.rainbowshit = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 391);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "TopMost";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 385);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.iconBox);
            this.tabPage1.Controls.Add(this.iconLabel);
            this.tabPage1.Controls.Add(this.iconButton);
            this.tabPage1.Controls.Add(this.iconImage);
            this.tabPage1.Controls.Add(this.keyLabel);
            this.tabPage1.Controls.Add(this.keyBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(314, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // iconBox
            // 
            this.iconBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconBox.Location = new System.Drawing.Point(6, 131);
            this.iconBox.Name = "iconBox";
            this.iconBox.ReadOnly = true;
            this.iconBox.Size = new System.Drawing.Size(300, 20);
            this.iconBox.TabIndex = 12;
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLabel.Location = new System.Drawing.Point(3, 46);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(98, 13);
            this.iconLabel.TabIndex = 11;
            this.iconLabel.Text = "Change your Icon";
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton
            // 
            this.iconButton.Location = new System.Drawing.Point(88, 102);
            this.iconButton.Name = "iconButton";
            this.iconButton.Size = new System.Drawing.Size(95, 23);
            this.iconButton.TabIndex = 10;
            this.iconButton.Text = "Import...";
            this.iconButton.UseVisualStyleBackColor = true;
            this.iconButton.Click += new System.EventHandler(this.iconButton_Click);
            // 
            // iconImage
            // 
            this.iconImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconImage.Location = new System.Drawing.Point(6, 62);
            this.iconImage.Name = "iconImage";
            this.iconImage.Size = new System.Drawing.Size(76, 63);
            this.iconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconImage.TabIndex = 9;
            this.iconImage.TabStop = false;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.Location = new System.Drawing.Point(3, 7);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(24, 13);
            this.keyLabel.TabIndex = 6;
            this.keyLabel.Text = "Key";
            this.keyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyBox
            // 
            this.keyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyBox.Location = new System.Drawing.Point(6, 23);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(300, 20);
            this.keyBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.fileverBox);
            this.tabPage2.Controls.Add(this.assFileVer);
            this.tabPage2.Controls.Add(this.proverBox);
            this.tabPage2.Controls.Add(this.assProVer);
            this.tabPage2.Controls.Add(this.oriBox);
            this.tabPage2.Controls.Add(this.assOri);
            this.tabPage2.Controls.Add(this.tradeBox);
            this.tabPage2.Controls.Add(this.assTrade);
            this.tabPage2.Controls.Add(this.assCopy);
            this.tabPage2.Controls.Add(this.assCom);
            this.tabPage2.Controls.Add(this.assDes);
            this.tabPage2.Controls.Add(this.assPro);
            this.tabPage2.Controls.Add(this.assemblyLabel);
            this.tabPage2.Controls.Add(this.copyBox);
            this.tabPage2.Controls.Add(this.comBox);
            this.tabPage2.Controls.Add(this.desBox);
            this.tabPage2.Controls.Add(this.proBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(314, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Assembly";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fileverBox
            // 
            this.fileverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileverBox.Enabled = false;
            this.fileverBox.Location = new System.Drawing.Point(6, 321);
            this.fileverBox.Name = "fileverBox";
            this.fileverBox.Size = new System.Drawing.Size(300, 20);
            this.fileverBox.TabIndex = 16;
            // 
            // assFileVer
            // 
            this.assFileVer.AutoSize = true;
            this.assFileVer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assFileVer.Location = new System.Drawing.Point(3, 304);
            this.assFileVer.Name = "assFileVer";
            this.assFileVer.Size = new System.Drawing.Size(67, 13);
            this.assFileVer.TabIndex = 15;
            this.assFileVer.Text = "File Version";
            this.assFileVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proverBox
            // 
            this.proverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proverBox.Enabled = false;
            this.proverBox.Location = new System.Drawing.Point(6, 281);
            this.proverBox.Name = "proverBox";
            this.proverBox.Size = new System.Drawing.Size(300, 20);
            this.proverBox.TabIndex = 14;
            // 
            // assProVer
            // 
            this.assProVer.AutoSize = true;
            this.assProVer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assProVer.Location = new System.Drawing.Point(3, 265);
            this.assProVer.Name = "assProVer";
            this.assProVer.Size = new System.Drawing.Size(89, 13);
            this.assProVer.TabIndex = 13;
            this.assProVer.Text = "Product Version";
            this.assProVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oriBox
            // 
            this.oriBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oriBox.Enabled = false;
            this.oriBox.Location = new System.Drawing.Point(6, 242);
            this.oriBox.Name = "oriBox";
            this.oriBox.Size = new System.Drawing.Size(300, 20);
            this.oriBox.TabIndex = 12;
            // 
            // assOri
            // 
            this.assOri.AutoSize = true;
            this.assOri.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assOri.Location = new System.Drawing.Point(3, 226);
            this.assOri.Name = "assOri";
            this.assOri.Size = new System.Drawing.Size(98, 13);
            this.assOri.TabIndex = 11;
            this.assOri.Text = "Original Filename";
            this.assOri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tradeBox
            // 
            this.tradeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tradeBox.Enabled = false;
            this.tradeBox.Location = new System.Drawing.Point(6, 203);
            this.tradeBox.Name = "tradeBox";
            this.tradeBox.Size = new System.Drawing.Size(300, 20);
            this.tradeBox.TabIndex = 10;
            // 
            // assTrade
            // 
            this.assTrade.AutoSize = true;
            this.assTrade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assTrade.Location = new System.Drawing.Point(3, 187);
            this.assTrade.Name = "assTrade";
            this.assTrade.Size = new System.Drawing.Size(65, 13);
            this.assTrade.TabIndex = 9;
            this.assTrade.Text = "Trademarks";
            this.assTrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assCopy
            // 
            this.assCopy.AutoSize = true;
            this.assCopy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assCopy.Location = new System.Drawing.Point(3, 148);
            this.assCopy.Name = "assCopy";
            this.assCopy.Size = new System.Drawing.Size(58, 13);
            this.assCopy.TabIndex = 8;
            this.assCopy.Text = "Copyright";
            this.assCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assCom
            // 
            this.assCom.AutoSize = true;
            this.assCom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assCom.Location = new System.Drawing.Point(3, 109);
            this.assCom.Name = "assCom";
            this.assCom.Size = new System.Drawing.Size(55, 13);
            this.assCom.TabIndex = 7;
            this.assCom.Text = "Company";
            this.assCom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assDes
            // 
            this.assDes.AutoSize = true;
            this.assDes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assDes.Location = new System.Drawing.Point(3, 70);
            this.assDes.Name = "assDes";
            this.assDes.Size = new System.Drawing.Size(66, 13);
            this.assDes.TabIndex = 6;
            this.assDes.Text = "Description";
            this.assDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assPro
            // 
            this.assPro.AutoSize = true;
            this.assPro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assPro.Location = new System.Drawing.Point(3, 31);
            this.assPro.Name = "assPro";
            this.assPro.Size = new System.Drawing.Size(47, 13);
            this.assPro.TabIndex = 5;
            this.assPro.Text = "Product";
            this.assPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assemblyLabel
            // 
            this.assemblyLabel.AutoSize = true;
            this.assemblyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assemblyLabel.Location = new System.Drawing.Point(7, 7);
            this.assemblyLabel.Name = "assemblyLabel";
            this.assemblyLabel.Size = new System.Drawing.Size(144, 17);
            this.assemblyLabel.TabIndex = 4;
            this.assemblyLabel.Text = ". : Assembly Changer : .";
            this.assemblyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copyBox
            // 
            this.copyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.copyBox.Enabled = false;
            this.copyBox.Location = new System.Drawing.Point(6, 164);
            this.copyBox.Name = "copyBox";
            this.copyBox.Size = new System.Drawing.Size(300, 20);
            this.copyBox.TabIndex = 3;
            // 
            // comBox
            // 
            this.comBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comBox.Enabled = false;
            this.comBox.Location = new System.Drawing.Point(6, 125);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(300, 20);
            this.comBox.TabIndex = 2;
            // 
            // desBox
            // 
            this.desBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desBox.Enabled = false;
            this.desBox.Location = new System.Drawing.Point(6, 86);
            this.desBox.Name = "desBox";
            this.desBox.Size = new System.Drawing.Size(298, 20);
            this.desBox.TabIndex = 1;
            // 
            // proBox
            // 
            this.proBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proBox.Enabled = false;
            this.proBox.Location = new System.Drawing.Point(6, 47);
            this.proBox.Name = "proBox";
            this.proBox.Size = new System.Drawing.Size(300, 20);
            this.proBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buildButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(314, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Build!";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(65, 156);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(174, 35);
            this.buildButton.TabIndex = 12;
            this.buildButton.Text = "Build!";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(81, 391);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Rainbow Effect";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rainbowshit
            // 
            this.rainbowshit.Tick += new System.EventHandler(this.rainbowshit_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(243, 9);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 17);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Enable";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LmaoBuilder | Simple Builder for LmaoLocker";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox copyBox;
        private System.Windows.Forms.TextBox comBox;
        private System.Windows.Forms.TextBox desBox;
        private System.Windows.Forms.TextBox proBox;
        private System.Windows.Forms.Label assemblyLabel;
        private System.Windows.Forms.Label assDes;
        private System.Windows.Forms.Label assPro;
        private System.Windows.Forms.Label assCom;
        private System.Windows.Forms.Label assCopy;
        private System.Windows.Forms.TextBox tradeBox;
        private System.Windows.Forms.Label assTrade;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Timer rainbowshit;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button iconButton;
        private System.Windows.Forms.PictureBox iconImage;
        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox iconBox;
        private System.Windows.Forms.TextBox fileverBox;
        private System.Windows.Forms.Label assFileVer;
        private System.Windows.Forms.TextBox proverBox;
        private System.Windows.Forms.Label assProVer;
        private System.Windows.Forms.TextBox oriBox;
        private System.Windows.Forms.Label assOri;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

