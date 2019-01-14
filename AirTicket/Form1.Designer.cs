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
            this.button1 = new System.Windows.Forms.Button();
            this.btnVietJet = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNewCountry = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVietJet
            // 
            this.btnVietJet.Location = new System.Drawing.Point(36, 93);
            this.btnVietJet.Name = "btnVietJet";
            this.btnVietJet.Size = new System.Drawing.Size(75, 23);
            this.btnVietJet.TabIndex = 1;
            this.btnVietJet.Text = "button2";
            this.btnVietJet.UseVisualStyleBackColor = true;
            this.btnVietJet.Click += new System.EventHandler(this.btnVietJet_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewCountry});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 373);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnVietJet);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVietJet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNewCountry;
    }
}

