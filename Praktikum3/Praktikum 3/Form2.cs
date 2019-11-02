using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_3
{
    public partial class FormPict : Form
    {
        int deg, n;
        Image gbrAsli;
        Form1 FrmParent;

        public FormPict(Form1 F1)
        {
            InitializeComponent();
            FrmParent = F1;
        }

        public void setpic(Image img)
        {
            pictureBox1.Image = img;
            gbrAsli = pictureBox1.Image;
        }

        public void PutarKanan()
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            deg += 90;
            if(deg > 360) { deg = deg - 360; }
            pictureBox1.Image = flipImage;
            textBox1.Text = deg.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmParent.AllDegree1 = deg;
        }

        //ROTATE 
        private void button2_Click(object sender, EventArgs e)
        {
            int a1, a2;
            a1 = FrmParent.AllDegree1 / 90;
            a2 = deg / 90;
            if(a2 < a1)
            {
                for(int i=a2; i < a1; i++)
                {
                    PutarKanan();
                }
            }else if(a2 > a1)
            {
                for (int i = a1; i < a2; i++)
                {
                    PutarKiri();
                }
            }
        }

        public void PutarKiri()
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            deg -= 90;
            if (deg < 0) { deg = 270; }
            pictureBox1.Image = flipImage;
            textBox1.Text = deg.ToString();
        }


        //ZOOM
        int w, h, size;

        private void button4_Click(object sender, EventArgs e)
        {
            FrmParent.AllHeight1 = h;
            FrmParent.AllWidth1 = w;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = FrmParent.AllHeight1;
            pictureBox1.Width = FrmParent.AllWidth1;
        }

            //ZOOM
            public void zoomIn()
        {
            h = (int)(pictureBox1.Height += 50);
            w = (int)(pictureBox1.Width += 50);
            size += 50;
        }

        public void zoomOut()
        {
            h = (int)(pictureBox1.Height -= 50);
            w = (int)(pictureBox1.Width -= 50);
            size -= 50;
        }

    }
}
