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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnVNAir = new System.Windows.Forms.Button();
            this.btnVietJet = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNewCountry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFixCountry = new System.Windows.Forms.ToolStripButton();
            this.btnJetStar = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCalendar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVNAir
            // 
            this.btnVNAir.Location = new System.Drawing.Point(48, 36);
            this.btnVNAir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVNAir.Name = "btnVNAir";
            this.btnVNAir.Size = new System.Drawing.Size(144, 28);
            this.btnVNAir.TabIndex = 0;
            this.btnVNAir.Text = "VietNam Airline";
            this.btnVNAir.UseVisualStyleBackColor = true;
            this.btnVNAir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVietJet
            // 
            this.btnVietJet.Location = new System.Drawing.Point(48, 114);
            this.btnVietJet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVietJet.Name = "btnVietJet";
            this.btnVietJet.Size = new System.Drawing.Size(144, 28);
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
            this.tsCalendar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(659, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNewCountry
            // 
            this.tsNewCountry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNewCountry.Image = ((System.Drawing.Image)(resources.GetObject("tsNewCountry.Image")));
            this.tsNewCountry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNewCountry.Name = "tsNewCountry";
            this.tsNewCountry.Size = new System.Drawing.Size(98, 24);
            this.tsNewCountry.Text = "Data country";
            this.tsNewCountry.Click += new System.EventHandler(this.tsNewCountry_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsFixCountry
            // 
            this.tsFixCountry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFixCountry.Image = ((System.Drawing.Image)(resources.GetObject("tsFixCountry.Image")));
            this.tsFixCountry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFixCountry.Name = "tsFixCountry";
            this.tsFixCountry.Size = new System.Drawing.Size(84, 24);
            this.tsFixCountry.Text = "Fix country";
            this.tsFixCountry.Click += new System.EventHandler(this.tsFixCountry_Click);
            // 
            // btnJetStar
            // 
            this.btnJetStar.Location = new System.Drawing.Point(48, 190);
            this.btnJetStar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJetStar.Name = "btnJetStar";
            this.btnJetStar.Size = new System.Drawing.Size(144, 28);
            this.btnJetStar.TabIndex = 3;
            this.btnJetStar.Text = "JetStar";
            this.btnJetStar.UseVisualStyleBackColor = true;
            this.btnJetStar.Click += new System.EventHandler(this.btnJetStar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsCalendar
            // 
            this.tsCalendar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsCalendar.Image = ((System.Drawing.Image)(resources.GetObject("tsCalendar.Image")));
            this.tsCalendar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCalendar.Name = "tsCalendar";
            this.tsCalendar.Size = new System.Drawing.Size(65, 24);
            this.tsCalendar.Text = "Tạo lịch";
            this.tsCalendar.Click += new System.EventHandler(this.tsCalendar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 459);
            this.Controls.Add(this.btnJetStar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnVietJet);
            this.Controls.Add(this.btnVNAir);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}

