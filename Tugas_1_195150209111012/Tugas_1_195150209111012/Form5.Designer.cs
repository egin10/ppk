namespace Tugas_1_195150209111012
{
    partial class Form5
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
            this.tbNamaMhs = new System.Windows.Forms.TextBox();
            this.contextMenuNama = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuNama.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNamaMhs
            // 
            this.tbNamaMhs.ContextMenuStrip = this.contextMenuNama;
            this.tbNamaMhs.Location = new System.Drawing.Point(25, 41);
            this.tbNamaMhs.Name = "tbNamaMhs";
            this.tbNamaMhs.Size = new System.Drawing.Size(283, 20);
            this.tbNamaMhs.TabIndex = 0;
            // 
            // contextMenuNama
            // 
            this.contextMenuNama.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salinToolStripMenuItem,
            this.tempelToolStripMenuItem,
            this.hapusToolStripMenuItem});
            this.contextMenuNama.Name = "contextMenuNama";
            this.contextMenuNama.Size = new System.Drawing.Size(113, 70);
            this.contextMenuNama.Text = "contextMenuNama";
            // 
            // salinToolStripMenuItem
            // 
            this.salinToolStripMenuItem.Name = "salinToolStripMenuItem";
            this.salinToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.salinToolStripMenuItem.Text = "Salin";
            // 
            // tempelToolStripMenuItem
            // 
            this.tempelToolStripMenuItem.Name = "tempelToolStripMenuItem";
            this.tempelToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.tempelToolStripMenuItem.Text = "Tempel";
            // 
            // hapusToolStripMenuItem
            // 
            this.hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
            this.hapusToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.hapusToolStripMenuItem.Text = "Hapus";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 409);
            this.ContextMenuStrip = this.contextMenuNama;
            this.Controls.Add(this.tbNamaMhs);
            this.Name = "Form5";
            this.Text = "Form5";
            this.contextMenuNama.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNamaMhs;
        private System.Windows.Forms.ContextMenuStrip contextMenuNama;
        private System.Windows.Forms.ToolStripMenuItem salinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
    }
}