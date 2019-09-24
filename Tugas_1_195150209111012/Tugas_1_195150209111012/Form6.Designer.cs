namespace Tugas_1_195150209111012
{
    partial class Form6
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
            this.btnGanti = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.dlgWarna = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnGanti
            // 
            this.btnGanti.Location = new System.Drawing.Point(34, 32);
            this.btnGanti.Name = "btnGanti";
            this.btnGanti.Size = new System.Drawing.Size(124, 23);
            this.btnGanti.TabIndex = 0;
            this.btnGanti.Text = "Ganti Background";
            this.btnGanti.UseVisualStyleBackColor = true;
            this.btnGanti.Click += new System.EventHandler(this.btnGanti_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(174, 32);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 1;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 380);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnGanti);
            this.Name = "Form6";
            this.Text = "Kotak Dialog Warna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGanti;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.ColorDialog dlgWarna;
    }
}