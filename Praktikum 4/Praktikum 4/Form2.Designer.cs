namespace Praktikum_4
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNIM = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbFakultas = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtFakultas = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSrcMhs = new System.Windows.Forms.Button();
            this.lbDataMhs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtPengarang = new System.Windows.Forms.TextBox();
            this.btnSrcBuku = new System.Windows.Forms.Button();
            this.lbDataBuku = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.lbJumlah = new System.Windows.Forms.Label();
            this.lbPengarang = new System.Windows.Forms.Label();
            this.lbJudul = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateKembali = new System.Windows.Forms.DateTimePicker();
            this.datePinjam = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtJmlPinjam = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbDataPinjaman = new System.Windows.Forms.Label();
            this.lbJmlPinjam = new System.Windows.Forms.Label();
            this.lbTglKembali = new System.Windows.Forms.Label();
            this.lbTglPinjam = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PEMINJAMAN";
            // 
            // lbNIM
            // 
            this.lbNIM.AutoSize = true;
            this.lbNIM.Location = new System.Drawing.Point(6, 34);
            this.lbNIM.Name = "lbNIM";
            this.lbNIM.Size = new System.Drawing.Size(27, 13);
            this.lbNIM.TabIndex = 1;
            this.lbNIM.Text = "NIM";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(5, 61);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(35, 13);
            this.lbNama.TabIndex = 2;
            this.lbNama.Text = "Nama";
            // 
            // lbFakultas
            // 
            this.lbFakultas.AutoSize = true;
            this.lbFakultas.Location = new System.Drawing.Point(6, 89);
            this.lbFakultas.Name = "lbFakultas";
            this.lbFakultas.Size = new System.Drawing.Size(47, 13);
            this.lbFakultas.TabIndex = 3;
            this.lbFakultas.Text = "Fakultas";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(92, 34);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.ReadOnly = true;
            this.txtNIM.Size = new System.Drawing.Size(135, 20);
            this.txtNIM.TabIndex = 4;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(92, 61);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(135, 20);
            this.txtNama.TabIndex = 5;
            // 
            // txtFakultas
            // 
            this.txtFakultas.Location = new System.Drawing.Point(92, 87);
            this.txtFakultas.Name = "txtFakultas";
            this.txtFakultas.ReadOnly = true;
            this.txtFakultas.Size = new System.Drawing.Size(135, 20);
            this.txtFakultas.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(255, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(313, 124);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSrcMhs);
            this.panel1.Controls.Add(this.lbDataMhs);
            this.panel1.Controls.Add(this.txtFakultas);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Controls.Add(this.txtNIM);
            this.panel1.Controls.Add(this.lbFakultas);
            this.panel1.Controls.Add(this.lbNama);
            this.panel1.Controls.Add(this.lbNIM);
            this.panel1.Location = new System.Drawing.Point(8, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 124);
            this.panel1.TabIndex = 8;
            // 
            // btnSrcMhs
            // 
            this.btnSrcMhs.Location = new System.Drawing.Point(152, 7);
            this.btnSrcMhs.Name = "btnSrcMhs";
            this.btnSrcMhs.Size = new System.Drawing.Size(75, 23);
            this.btnSrcMhs.TabIndex = 10;
            this.btnSrcMhs.Text = "Tampilkan";
            this.btnSrcMhs.UseVisualStyleBackColor = true;
            this.btnSrcMhs.Click += new System.EventHandler(this.btnSrcMhs_Click);
            // 
            // lbDataMhs
            // 
            this.lbDataMhs.AutoSize = true;
            this.lbDataMhs.Location = new System.Drawing.Point(6, 7);
            this.lbDataMhs.Name = "lbDataMhs";
            this.lbDataMhs.Size = new System.Drawing.Size(86, 13);
            this.lbDataMhs.TabIndex = 7;
            this.lbDataMhs.Text = "Data Mahasiswa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtJumlah);
            this.panel2.Controls.Add(this.txtPengarang);
            this.panel2.Controls.Add(this.btnSrcBuku);
            this.panel2.Controls.Add(this.lbDataBuku);
            this.panel2.Controls.Add(this.txtJudul);
            this.panel2.Controls.Add(this.lbJumlah);
            this.panel2.Controls.Add(this.lbPengarang);
            this.panel2.Controls.Add(this.lbJudul);
            this.panel2.Location = new System.Drawing.Point(9, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 124);
            this.panel2.TabIndex = 9;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(93, 86);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.ReadOnly = true;
            this.txtJumlah.Size = new System.Drawing.Size(135, 20);
            this.txtJumlah.TabIndex = 13;
            // 
            // txtPengarang
            // 
            this.txtPengarang.Location = new System.Drawing.Point(92, 60);
            this.txtPengarang.Name = "txtPengarang";
            this.txtPengarang.ReadOnly = true;
            this.txtPengarang.Size = new System.Drawing.Size(135, 20);
            this.txtPengarang.TabIndex = 12;
            // 
            // btnSrcBuku
            // 
            this.btnSrcBuku.Location = new System.Drawing.Point(153, 5);
            this.btnSrcBuku.Name = "btnSrcBuku";
            this.btnSrcBuku.Size = new System.Drawing.Size(75, 23);
            this.btnSrcBuku.TabIndex = 11;
            this.btnSrcBuku.Text = "Tampilkan";
            this.btnSrcBuku.UseVisualStyleBackColor = true;
            this.btnSrcBuku.Click += new System.EventHandler(this.btnSrcBuku_Click);
            // 
            // lbDataBuku
            // 
            this.lbDataBuku.AutoSize = true;
            this.lbDataBuku.Location = new System.Drawing.Point(6, 7);
            this.lbDataBuku.Name = "lbDataBuku";
            this.lbDataBuku.Size = new System.Drawing.Size(58, 13);
            this.lbDataBuku.TabIndex = 7;
            this.lbDataBuku.Text = "Data Buku";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(93, 34);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.ReadOnly = true;
            this.txtJudul.Size = new System.Drawing.Size(135, 20);
            this.txtJudul.TabIndex = 4;
            // 
            // lbJumlah
            // 
            this.lbJumlah.AutoSize = true;
            this.lbJumlah.Location = new System.Drawing.Point(6, 89);
            this.lbJumlah.Name = "lbJumlah";
            this.lbJumlah.Size = new System.Drawing.Size(40, 13);
            this.lbJumlah.TabIndex = 3;
            this.lbJumlah.Text = "Jumlah";
            // 
            // lbPengarang
            // 
            this.lbPengarang.AutoSize = true;
            this.lbPengarang.Location = new System.Drawing.Point(5, 61);
            this.lbPengarang.Name = "lbPengarang";
            this.lbPengarang.Size = new System.Drawing.Size(59, 13);
            this.lbPengarang.TabIndex = 2;
            this.lbPengarang.Text = "Pengarang";
            // 
            // lbJudul
            // 
            this.lbJudul.AutoSize = true;
            this.lbJudul.Location = new System.Drawing.Point(6, 34);
            this.lbJudul.Name = "lbJudul";
            this.lbJudul.Size = new System.Drawing.Size(32, 13);
            this.lbJudul.TabIndex = 1;
            this.lbJudul.Text = "Judul";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateKembali);
            this.panel3.Controls.Add(this.datePinjam);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.txtJmlPinjam);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.lbDataPinjaman);
            this.panel3.Controls.Add(this.lbJmlPinjam);
            this.panel3.Controls.Add(this.lbTglKembali);
            this.panel3.Controls.Add(this.lbTglPinjam);
            this.panel3.Location = new System.Drawing.Point(8, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 142);
            this.panel3.TabIndex = 14;
            // 
            // dateKembali
            // 
            this.dateKembali.Location = new System.Drawing.Point(96, 59);
            this.dateKembali.Name = "dateKembali";
            this.dateKembali.Size = new System.Drawing.Size(135, 20);
            this.dateKembali.TabIndex = 16;
            // 
            // datePinjam
            // 
            this.datePinjam.Location = new System.Drawing.Point(96, 33);
            this.datePinjam.Name = "datePinjam";
            this.datePinjam.Size = new System.Drawing.Size(135, 20);
            this.datePinjam.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(379, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtJmlPinjam
            // 
            this.txtJmlPinjam.Location = new System.Drawing.Point(96, 86);
            this.txtJmlPinjam.Name = "txtJmlPinjam";
            this.txtJmlPinjam.Size = new System.Drawing.Size(135, 20);
            this.txtJmlPinjam.TabIndex = 13;
            this.txtJmlPinjam.TextChanged += new System.EventHandler(this.txtJmlPinjam_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(460, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbDataPinjaman
            // 
            this.lbDataPinjaman.AutoSize = true;
            this.lbDataPinjaman.Location = new System.Drawing.Point(6, 7);
            this.lbDataPinjaman.Name = "lbDataPinjaman";
            this.lbDataPinjaman.Size = new System.Drawing.Size(76, 13);
            this.lbDataPinjaman.TabIndex = 7;
            this.lbDataPinjaman.Text = "Data Pinjaman";
            // 
            // lbJmlPinjam
            // 
            this.lbJmlPinjam.AutoSize = true;
            this.lbJmlPinjam.Location = new System.Drawing.Point(6, 89);
            this.lbJmlPinjam.Name = "lbJmlPinjam";
            this.lbJmlPinjam.Size = new System.Drawing.Size(74, 13);
            this.lbJmlPinjam.TabIndex = 3;
            this.lbJmlPinjam.Text = "Jumlah Pinjam";
            // 
            // lbTglKembali
            // 
            this.lbTglKembali.AutoSize = true;
            this.lbTglKembali.Location = new System.Drawing.Point(4, 61);
            this.lbTglKembali.Name = "lbTglKembali";
            this.lbTglKembali.Size = new System.Drawing.Size(86, 13);
            this.lbTglKembali.TabIndex = 2;
            this.lbTglKembali.Text = "Tanggal Kembali";
            // 
            // lbTglPinjam
            // 
            this.lbTglPinjam.AutoSize = true;
            this.lbTglPinjam.Location = new System.Drawing.Point(6, 34);
            this.lbTglPinjam.Name = "lbTglPinjam";
            this.lbTglPinjam.Size = new System.Drawing.Size(80, 13);
            this.lbTglPinjam.TabIndex = 1;
            this.lbTglPinjam.Text = "Tanggal Pinjam";
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(255, 172);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(313, 124);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 460);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "195150209111012 - BAB 4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNIM;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbFakultas;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtFakultas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSrcMhs;
        private System.Windows.Forms.Label lbDataMhs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSrcBuku;
        private System.Windows.Forms.Label lbDataBuku;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label lbJumlah;
        private System.Windows.Forms.Label lbPengarang;
        private System.Windows.Forms.Label lbJudul;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtPengarang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtJmlPinjam;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbDataPinjaman;
        private System.Windows.Forms.Label lbJmlPinjam;
        private System.Windows.Forms.Label lbTglKembali;
        private System.Windows.Forms.Label lbTglPinjam;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.DateTimePicker dateKembali;
        private System.Windows.Forms.DateTimePicker datePinjam;
    }
}