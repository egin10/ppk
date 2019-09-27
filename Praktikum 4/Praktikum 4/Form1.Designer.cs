namespace Praktikum_4
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_buku = new System.Windows.Forms.Label();
            this.label_pengarang = new System.Windows.Forms.Label();
            this.label_jumlah = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_judul = new System.Windows.Forms.TextBox();
            this.text_pengarang = new System.Windows.Forms.TextBox();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.button_Hapus = new System.Windows.Forms.Button();
            this.button_Tambah = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.listBuku = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Judul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pengarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jumlah = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.text_search = new System.Windows.Forms.TextBox();
            this.search_buku = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnDataPinjam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(38, 78);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(44, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Id Buku";
            // 
            // label_buku
            // 
            this.label_buku.AutoSize = true;
            this.label_buku.Location = new System.Drawing.Point(38, 106);
            this.label_buku.Name = "label_buku";
            this.label_buku.Size = new System.Drawing.Size(60, 13);
            this.label_buku.TabIndex = 1;
            this.label_buku.Text = "Judul Buku";
            // 
            // label_pengarang
            // 
            this.label_pengarang.AutoSize = true;
            this.label_pengarang.Location = new System.Drawing.Point(38, 135);
            this.label_pengarang.Name = "label_pengarang";
            this.label_pengarang.Size = new System.Drawing.Size(59, 13);
            this.label_pengarang.TabIndex = 2;
            this.label_pengarang.Text = "Pengarang";
            // 
            // label_jumlah
            // 
            this.label_jumlah.AutoSize = true;
            this.label_jumlah.Location = new System.Drawing.Point(38, 168);
            this.label_jumlah.Name = "label_jumlah";
            this.label_jumlah.Size = new System.Drawing.Size(40, 13);
            this.label_jumlah.TabIndex = 3;
            this.label_jumlah.Text = "Jumlah";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(122, 78);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(133, 20);
            this.text_id.TabIndex = 4;
            // 
            // text_judul
            // 
            this.text_judul.Location = new System.Drawing.Point(122, 107);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(133, 20);
            this.text_judul.TabIndex = 5;
            // 
            // text_pengarang
            // 
            this.text_pengarang.Location = new System.Drawing.Point(122, 136);
            this.text_pengarang.Name = "text_pengarang";
            this.text_pengarang.Size = new System.Drawing.Size(133, 20);
            this.text_pengarang.TabIndex = 6;
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(122, 166);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(133, 20);
            this.text_jumlah.TabIndex = 7;
            // 
            // button_Hapus
            // 
            this.button_Hapus.Location = new System.Drawing.Point(180, 195);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(75, 23);
            this.button_Hapus.TabIndex = 8;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = true;
            this.button_Hapus.Click += new System.EventHandler(this.button_Hapus_Click);
            // 
            // button_Tambah
            // 
            this.button_Tambah.Location = new System.Drawing.Point(99, 195);
            this.button_Tambah.Name = "button_Tambah";
            this.button_Tambah.Size = new System.Drawing.Size(75, 23);
            this.button_Tambah.TabIndex = 9;
            this.button_Tambah.Text = "Tambah";
            this.button_Tambah.UseVisualStyleBackColor = true;
            this.button_Tambah.Click += new System.EventHandler(this.button_Tambah_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(99, 224);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 10;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(180, 224);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 11;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // listBuku
            // 
            this.listBuku.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Judul,
            this.Pengarang,
            this.Jumlah});
            this.listBuku.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBuku.Location = new System.Drawing.Point(273, 0);
            this.listBuku.Name = "listBuku";
            this.listBuku.Size = new System.Drawing.Size(293, 302);
            this.listBuku.TabIndex = 12;
            this.listBuku.UseCompatibleStateImageBehavior = false;
            this.listBuku.View = System.Windows.Forms.View.Details;
            this.listBuku.SelectedIndexChanged += new System.EventHandler(this.listBuku_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Judul
            // 
            this.Judul.Text = "Judul";
            this.Judul.Width = 84;
            // 
            // Pengarang
            // 
            this.Pengarang.Text = "Pengarang";
            this.Pengarang.Width = 84;
            // 
            // Jumlah
            // 
            this.Jumlah.Text = "Jumlah";
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(122, 12);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(133, 20);
            this.text_search.TabIndex = 14;
            // 
            // search_buku
            // 
            this.search_buku.AutoSize = true;
            this.search_buku.Location = new System.Drawing.Point(38, 12);
            this.search_buku.Name = "search_buku";
            this.search_buku.Size = new System.Drawing.Size(41, 13);
            this.search_buku.TabIndex = 13;
            this.search_buku.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(180, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPinjam
            // 
            this.btnPinjam.Location = new System.Drawing.Point(180, 253);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(75, 41);
            this.btnPinjam.TabIndex = 16;
            this.btnPinjam.Text = "Form Peminjaman";
            this.btnPinjam.UseVisualStyleBackColor = true;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);
            // 
            // btnDataPinjam
            // 
            this.btnDataPinjam.Location = new System.Drawing.Point(99, 253);
            this.btnDataPinjam.Name = "btnDataPinjam";
            this.btnDataPinjam.Size = new System.Drawing.Size(75, 41);
            this.btnDataPinjam.TabIndex = 17;
            this.btnDataPinjam.Text = "Data Peminjaman";
            this.btnDataPinjam.UseVisualStyleBackColor = true;
            this.btnDataPinjam.Click += new System.EventHandler(this.btnDataPinjam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 302);
            this.Controls.Add(this.btnDataPinjam);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.search_buku);
            this.Controls.Add(this.listBuku);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Tambah);
            this.Controls.Add(this.button_Hapus);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.text_pengarang);
            this.Controls.Add(this.text_judul);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label_jumlah);
            this.Controls.Add(this.label_pengarang);
            this.Controls.Add(this.label_buku);
            this.Controls.Add(this.label_id);
            this.Name = "Form1";
            this.Text = "19515020911012 - BAB 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_buku;
        private System.Windows.Forms.Label label_pengarang;
        private System.Windows.Forms.Label label_jumlah;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_judul;
        private System.Windows.Forms.TextBox text_pengarang;
        private System.Windows.Forms.TextBox text_jumlah;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.Button button_Tambah;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ListView listBuku;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Judul;
        private System.Windows.Forms.ColumnHeader Pengarang;
        private System.Windows.Forms.ColumnHeader Jumlah;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Label search_buku;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPinjam;
        private System.Windows.Forms.Button btnDataPinjam;
    }
}

