namespace Tugas_2_PPK_195150209111012
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
            this.lbHalo = new System.Windows.Forms.Label();
            this.btnUbah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHalo
            // 
            this.lbHalo.AutoSize = true;
            this.lbHalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHalo.Location = new System.Drawing.Point(32, 42);
            this.lbHalo.Name = "lbHalo";
            this.lbHalo.Size = new System.Drawing.Size(36, 15);
            this.lbHalo.TabIndex = 0;
            this.lbHalo.Text = "Hallo";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(344, 37);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(89, 23);
            this.btnUbah.TabIndex = 1;
            this.btnUbah.Text = "Ubah Label";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.tutupAplikasi);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.lbHalo);
            this.Name = "Form1";
            this.Text = "195150209111012 - 2.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHalo;
        private System.Windows.Forms.Button btnUbah;
    }
}

