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
    public partial class Form2 : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=perpustakaan;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        String id_buku;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSrcMhs_Click(object sender, EventArgs e)
        {
            this.getData("mhs");
        }

        private void btnSrcBuku_Click(object sender, EventArgs e)
        {
            this.getData("data_buku");
        }

        private void getData(String tbl)
        {
            string query = "SELECT * FROM " + tbl;
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
                    if(tbl == "mhs")
                    {
                        listView1.Items.Clear();
                        listView1.Columns.Clear();
                        listView1.Columns.Add("No");
                        listView1.Columns.Add("Nim");
                        listView1.Columns.Add("Nama");
                        listView1.Columns.Add("Fakultas");

                        int n = 1;
                        while (reader.Read())
                        {
                            ListViewItem listViewItem1 = new
                            ListViewItem(n.ToString());
                            listViewItem1.SubItems.Add(reader["nim"].ToString());
                            listViewItem1.SubItems.Add(reader["nama"].ToString());
                            listViewItem1.SubItems.Add(reader["fakultas"].ToString());
                            listView1.Items.Add(listViewItem1);
                            n++;
                        }
                    }
                    else
                    {
                        listView2.Items.Clear();
                        listView2.Columns.Clear();
                        listView2.Columns.Add("No");
                        listView2.Columns.Add("Judul");
                        listView2.Columns.Add("Pengarang");
                        listView2.Columns.Add("Jumlah");

                        int n = 1;
                        while (reader.Read())
                        {
                            ListViewItem listViewItem2 = new
                            ListViewItem(n.ToString());
                            listViewItem2.SubItems.Add(reader["judul"].ToString());
                            listViewItem2.SubItems.Add(reader["pengarang"].ToString());
                            listViewItem2.SubItems.Add(reader["jumlah"].ToString());
                            listView2.Items.Add(listViewItem2);
                            this.id_buku = reader["id_buku"].ToString();
                            n++;
                        }
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

        ListViewItem item1;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                item1 = listView1.SelectedItems[0];
                txtNIM.Text = item1.SubItems[1].Text;
                txtNama.Text = item1.SubItems[2].Text;
                txtFakultas.Text = item1.SubItems[3].Text;
            }
            else
            {
                txtNIM.Text = string.Empty;
                txtNama.Text = string.Empty;
                txtFakultas.Text = string.Empty;
            }
        }

        ListViewItem item2;
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                item2 = listView2.SelectedItems[0];
                txtJudul.Text = item2.SubItems[1].Text;
                txtPengarang.Text = item2.SubItems[2].Text;
                txtJumlah.Text = item2.SubItems[3].Text;
            }
            else
            {
                txtJudul.Text = string.Empty;
                txtPengarang.Text = string.Empty;
                txtJumlah.Text = string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String msg = "NIM : " + txtNIM.Text + "\nID BUKU : " + id_buku + "\nDate : " + datePinjam.Value.Date.ToString("yyyy-MM-dd") + " s/d " + dateKembali.Value.Date.ToString("yyyy-MM-dd") + "\nJumlah Buku yang dipinjam : " + txtJmlPinjam.Text ;
            MessageBox.Show(msg);
        }
    }
}
