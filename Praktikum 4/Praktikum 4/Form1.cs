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
    public partial class Form1 : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=perpustakaan;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Tambah_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO data_buku (id_buku, judul, pengarang, jumlah) VALUES (@id,@judul, @pengarang,@jumlah)";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                this.cleanForm();
                this.getData();
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            this.getData();
            this.cleanForm();
            text_search.Text = "";
        }

        private void button_Hapus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM data_buku WHERE id_buku = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                this.getData();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE data_buku SET judul = @judul, pengarang=@pengarang,jumlah = @jumlah WHERE id_buku = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                this.cleanForm();
                this.getData();
            }
        }

        public void getData()
        {
            listBuku.Items.Clear();
            string query = "SELECT * FROM data_buku";
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
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listBuku.Items.Add(listViewItem);
                    }
                    reader.Close();
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

        private void cleanForm()
        {
            text_id.Text = text_judul.Text = text_pengarang.Text = text_jumlah.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.getData();
        }

        ListViewItem item;
        private void listBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBuku.SelectedItems.Count > 0)
            {
                item = listBuku.SelectedItems[0];
                text_id.Text = item.SubItems[0].Text;
                text_judul.Text = item.SubItems[1].Text;
                text_pengarang.Text = item.SubItems[2].Text;
                text_jumlah.Text = item.SubItems[3].Text;
            }
            else
            {
                text_id.Text = string.Empty;
                text_judul.Text = string.Empty;
                text_pengarang.Text = string.Empty;
                text_jumlah.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBuku.Items.Clear();
            string query = "SELECT * FROM data_buku WHERE judul LIKE '%"+ text_search.Text +"%' OR pengarang LIKE '%"+ text_search.Text +"%'";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                //cmd.Parameters.AddWithValue("@s", text_search.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listBuku.Items.Add(listViewItem);
                    }
                    reader.Close();
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

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
