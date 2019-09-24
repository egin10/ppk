namespace Tugas_1_195150209111012
{
    partial class Form7
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnGantiFont = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(45, 25);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(78, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Hello World";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGantiFont
            // 
            this.btnGantiFont.Location = new System.Drawing.Point(38, 55);
            this.btnGantiFont.Name = "btnGantiFont";
            this.btnGantiFont.Size = new System.Drawing.Size(74, 25);
            this.btnGantiFont.TabIndex = 1;
            this.btnGantiFont.Text = "Ganti Font";
            this.btnGantiFont.UseVisualStyleBackColor = true;
            this.btnGantiFont.Click += new System.EventHandler(this.btnGantiFont_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(129, 55);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(74, 25);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // dlgFont
            // 
            this.dlgFont.ShowApply = true;
            this.dlgFont.ShowColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 346);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnGantiFont);
            this.Controls.Add(this.lblInfo);
            this.Name = "Form7";
            this.Text = "Kotak Dialog Font";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnGantiFont;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.FontDialog dlgFont;
    }
}