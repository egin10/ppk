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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tutupAplikasi(object sender, EventArgs e)
        {
            //lbHalo.Text = "Platform Khusus";
            lbHalo.Text = sender.ToString();
        }
    }
}
