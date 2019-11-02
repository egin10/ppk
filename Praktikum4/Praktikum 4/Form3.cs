using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_4
{
    public partial class Form3 : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=perpustakaan;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getData()
        {
            string query = "SELECT db.id_buku, db.judul, db.pengarang, m.nim, m.nama, m.fakultas, dp.tgl_pinjam, dp.tgl_kembali, dp.jumlah FROM data_pinjaman dp, data_buku db, mhs m WHERE dp.id_buku = db.id_buku AND dp.nim_mhs = m.nim";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    listView1.Items.Clear();
                    listView1.Columns.Clear();
                    listView1.Columns.Add("No");
                    listView1.Columns.Add("ID");
                    listView1.Columns.Add("Judul");
                    listView1.Columns.Add("Pengarang");
                    listView1.Columns.Add("NIM");
                    listView1.Columns.Add("Nama");
                    listView1.Columns.Add("Fakultas");
                    listView1.Columns.Add("Tanggal Pinjam");
                    listView1.Columns.Add("Tanggal Kembali");
                    listView1.Columns.Add("Jumlah");

                    int n = 1;
                    while (reader.Read())
                    {
                        ListViewItem listViewItem1 = new
                        ListViewItem(n.ToString());
                        listViewItem1.SubItems.Add(reader["id_buku"].ToString());
                        listViewItem1.SubItems.Add(reader["judul"].ToString());
                        listViewItem1.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem1.SubItems.Add(reader["nim"].ToString());
                        listViewItem1.SubItems.Add(reader["nama"].ToString());
                        listViewItem1.SubItems.Add(reader["fakultas"].ToString());
                        DateTime tgl_pinjam = DateTime.Parse(reader["tgl_pinjam"].ToString());
                        listViewItem1.SubItems.Add(tgl_pinjam.ToString("dd/MMM/yyyy"));
                        DateTime tgl_kembali = DateTime.Parse(reader["tgl_kembali"].ToString());
                        listViewItem1.SubItems.Add(tgl_kembali.ToString("dd/MMM/yyyy"));
                        listViewItem1.SubItems.Add(reader["jumlah"].ToString());
                        listView1.Items.Add(listViewItem1);
                        n++;
                    }
                    reader.Close();

                    for (int i = 0; i < listView1.Columns.Count; i++)
                    {
                        listView1.Columns[i].Width = -2;
                    }
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.getData();
        }
    }
}
