using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDI_MDI
{
    public partial class Form1 : Form
    {
        private String str;
        

        public static Form2 frm2;
        public static Form3 frmMdi3;

        public string Str { get => str; set => str = value; }

        public Form1()
        {
            InitializeComponent();
            frmMdi3 = new Form3(this);
            frmMdi3.MdiParent = this;
            frm2 = new Form2(this);
        }

        private void maximisedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frm2 != null)
            {
                frm2.WindowState = FormWindowState.Maximized;
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frm2 != null)
            {
                frm2.Show();
            }
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(frmMdi3 != null)
            {
                frmMdi3.Show();
            }
        }

        private void hideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(frmMdi3 != null)
            {
                frmMdi3.Hide();
            }
        }

        private void maximizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmMdi3 != null)
            {
                frmMdi3.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmMdi3 != null)
            {
                frmMdi3.WindowState = FormWindowState.Minimized;
            }
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frm2 != null)
            {
                frm2.Hide();
            }
        }

        private void minimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm2 != null)
            {
                frm2.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
