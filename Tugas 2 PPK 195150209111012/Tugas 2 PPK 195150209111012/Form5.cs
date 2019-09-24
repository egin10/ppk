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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text += "\nPosisi X: " + e.X + ", Y: " + e.Y;
        }

        private void Form5_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = "Key Code: " + e.KeyCode;
            label1.Text += "\nAlt " + e.Alt;
            label1.Text += "\nShift " + e.Shift;
            label1.Text += "\nControl " + e.Control;
            label1.Text += "\nKey Data " + e.KeyData;
            label1.Text += "\nKey value " + e.KeyValue + "\n\n";
        }
    }
}
