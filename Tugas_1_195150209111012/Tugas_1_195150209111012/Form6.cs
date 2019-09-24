using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_1_195150209111012
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnGanti_Click(object sender, EventArgs e)
        {
            DialogResult pilihan = dlgWarna.ShowDialog();
            if (pilihan == DialogResult.OK)
            {
                this.BackColor = dlgWarna.Color;
            }
        }
    }
}
