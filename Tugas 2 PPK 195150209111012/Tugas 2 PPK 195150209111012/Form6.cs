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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                if(e.KeyCode == Keys.A)
                {
                    label1.Text += "\nMemilih Semua";
                }
                else if (e.KeyCode == Keys.C)
                {
                    label1.Text += "\nMelakukan Salin Data";
                }
                else if (e.KeyCode == Keys.V)
                {
                    label1.Text += "\nMelakukan Tempel Data";
                }
                else if (e.KeyCode == Keys.P)
                {
                    label1.Text += "\nMelakukan Cetak";
                }
            }
        }

        int c = 1;
        private void Form6_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                label1.Text = "Tombol mouse ditekan adalah Kiri";
            }
            else if (e.Button == MouseButtons.Middle){
                label1.Text = "Tombol mouse ditekan adalah Tengah";
            }else
            {
                label1.Text = "Tombol mouse ditekan adalah Kanan";
            }
            label1.Text += "\nTombol ditekan sebanyak: " + c;
            c += e.Clicks;
        }

        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form6_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
