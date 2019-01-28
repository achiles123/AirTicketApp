namespace AirTicket
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
            this.btnVNAir = new System.Windows.Forms.Button();
            this.btnVietJet = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNewCountry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFixCountry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCalendar = new System.Windows.Forms.ToolStripButton();
            this.btnJetStar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbVNAirWarning = new System.Windows.Forms.Label();
            this.btnAirlineProcess = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVNAir
            // 
            this.btnVNAir.Location = new System.Drawing.Point(28, 15);
            this.btnVNAir.Name = "btnVNAir";
            this.btnVNAir.Size = new System.Drawing.Size(108, 23);
            this.btnVNAir.TabIndex = 0;
            this.btnVNAir.Text = "VietNam Airline";
            this.btnVNAir.UseVisualStyleBackColor = true;
            this.btnVNAir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVietJet
            // 
            this.btnVietJet.Location = new System.Drawing.Point(28, 79);
            this.btnVietJet.Name = "btnVietJet";
            this.btnVietJet.Size = new System.Drawing.Size(108, 23);
            this.btnVietJet.TabIndex = 1;
            this.btnVietJet.Text = "VietJet";
            this.btnVietJet.UseVisualStyleBackColor = true;
            this.btnVietJet.Click += new System.EventHandler(this.btnVietJet_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewCountry,
            this.toolStripSeparator1,
            this.tsFixCountry,
            this.toolStripSeparator2,
            this.tsCalendar,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1,
            this.toolStripSeparator4,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(494, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNewCountry
            // 
            this.tsNewCountry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNewCountry.Image = ((System.Drawing.Image)(resources.GetObject("tsNewCountry.Image")));
            this.tsNewCountry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNewCountry.Name = "tsNewCountry";
            this.tsNewCountry.Size = new System.Drawing.Size(79, 22);
            this.tsNewCountry.Text = "Data country";
            this.tsNewCountry.Click += new System.EventHandler(this.tsNewCountry_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsFixCountry
            // 
            this.tsFixCountry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFixCountry.Image = ((System.Drawing.Image)(resources.GetObject("tsFixCountry.Image")));
            this.tsFixCountry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFixCountry.Name = "tsFixCountry";
            this.tsFixCountry.Size = new System.Drawing.Size(69, 22);
            this.tsFixCountry.Text = "Fix country";
            this.tsFixCountry.Click += new System.EventHandler(this.tsFixCountry_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsCalendar
            // 
            this.tsCalendar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsCalendar.Image = ((System.Drawing.Image)(resources.GetObject("tsCalendar.Image")));
            this.tsCalendar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCalendar.Name = "tsCalendar";
            this.tsCalendar.Size = new System.Drawing.Size(53, 22);
            this.tsCalendar.Text = "Tạo lịch";
            this.tsCalendar.Click += new System.EventHandler(this.tsCalendar_Click);
            // 
            // btnJetStar
            // 
            this.btnJetStar.Location = new System.Drawing.Point(28, 140);
            this.btnJetStar.Name = "btnJetStar";
            this.btnJetStar.Size = new System.Drawing.Size(108, 23);
            this.btnJetStar.TabIndex = 3;
            this.btnJetStar.Text = "JetStar";
            this.btnJetStar.UseVisualStyleBackColor = true;
            this.btnJetStar.Click += new System.EventHandler(this.btnJetStar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 348);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnVietJet);
            this.tabPage1.Controls.Add(this.btnJetStar);
            this.tabPage1.Controls.Add(this.btnVNAir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(486, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Master";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.geckoWebBrowser1);
            this.tabPage2.Controls.Add(this.lbVNAirWarning);
            this.tabPage2.Controls.Add(this.btnAirlineProcess);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(486, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xử lý";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbVNAirWarning
            // 
            this.lbVNAirWarning.AutoSize = true;
            this.lbVNAirWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVNAirWarning.Location = new System.Drawing.Point(127, 37);
            this.lbVNAirWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVNAirWarning.Name = "lbVNAirWarning";
            this.lbVNAirWarning.Size = new System.Drawing.Size(0, 24);
            this.lbVNAirWarning.TabIndex = 5;
            // 
            // btnAirlineProcess
            // 
            this.btnAirlineProcess.Location = new System.Drawing.Point(30, 30);
            this.btnAirlineProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAirlineProcess.Name = "btnAirlineProcess";
            this.btnAirlineProcess.Size = new System.Drawing.Size(64, 27);
            this.btnAirlineProcess.TabIndex = 0;
            this.btnAirlineProcess.Text = "button1";
            this.btnAirlineProcess.UseVisualStyleBackColor = true;
            this.btnAirlineProcess.Click += new System.EventHandler(this.btnAirlineProcess_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToolStripMenuItem,
            this.uninstallToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 22);
            this.toolStripDropDownButton1.Text = "Ssl";
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.installToolStripMenuItem.Text = "Install";
            this.installToolStripMenuItem.Click += new System.EventHandler(this.installToolStripMenuItem_Click);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uninstallToolStripMenuItem.Text = "Uninstall";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.uninstallToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton2.Text = "Capture";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Location = new System.Drawing.Point(189, 47);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(260, 179);
            this.geckoWebBrowser1.TabIndex = 7;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 373);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVNAir;
        private System.Windows.Forms.Button btnVietJet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNewCountry;
        private System.Windows.Forms.Button btnJetStar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsFixCountry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsCalendar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAirlineProcess;
        private System.Windows.Forms.Label lbVNAirWarning;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

