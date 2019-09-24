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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_EnabledChanged(object sender, EventArgs e)
        {
            if (textBox1.Enabled)
            {
                label1.Text = "TextBox1 dapat diisi";
            }
            else
            {
                label1.Text = "TextBox1 tidak dapat diisi";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Text = "Memasuki TextBox1";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label1.Text = "Keluar dari TextBox1";
        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {
            if (textBox1.Visible)
            {
                label1.Text = "TextBox1 tampil";
            }
            else
            {
                label1.Text = "TextBox1 tersembunyi";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = !textBox1.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = !textBox1.Visible;
        }
    }
}
