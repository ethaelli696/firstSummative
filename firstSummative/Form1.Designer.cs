namespace firstSummative
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
            this.happyHannukah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // happyHannukah
            // 
            this.happyHannukah.AutoSize = true;
            this.happyHannukah.BackColor = System.Drawing.Color.Black;
            this.happyHannukah.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.happyHannukah.ForeColor = System.Drawing.Color.White;
            this.happyHannukah.Location = new System.Drawing.Point(138, 130);
            this.happyHannukah.Name = "happyHannukah";
            this.happyHannukah.Size = new System.Drawing.Size(453, 330);
            this.happyHannukah.TabIndex = 0;
            this.happyHannukah.Text = "Hercules\r\n\r\nClick to Learn More!\r\n\r\nEthan Elliott 2018\r\n\r\n";
            this.happyHannukah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::firstSummative.Properties.Resources.big;
            this.ClientSize = new System.Drawing.Size(740, 583);
            this.Controls.Add(this.happyHannukah);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hercules Greeting Card";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label happyHannukah;
    }
}

