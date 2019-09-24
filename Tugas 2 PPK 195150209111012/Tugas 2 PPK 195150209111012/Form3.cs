using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_2_PPK_195150209111012
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Text = "cb berubah menjadi dicentang";
            }
            else
            {
                label1.Text = "cb berubah menjadi tidak dicentang";
            }
        }

        private void checkBox1_EnabledChanged(object sender, EventArgs e)
        {
            if (checkBox1.Enabled)
            {
                label1.Text = "cb dapat dipilih";
            }
            else
            {
                label1.Text = "cb tidak dapat dipilih";
            }
        }

        private void checkBox1_Enter(object sender, EventArgs e)
        {
            label2.Text = "memasuki CB";
        }

        private void checkBox1_Leave(object sender, EventArgs e)
        {
            label2.Text = "Keluar CB";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = !checkBox1.Enabled;
        }
    }
}
