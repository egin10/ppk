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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_seleksi = false;

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "0";
            }
        }

        private void btnKoma_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            bil1 = 0;
            bil2 = 0;
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            opr = 1;
            opr_seleksi = true;
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            opr = 2;
            opr_seleksi = true;
        }

        private void btnKrng_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            opr = 3;
            opr_seleksi = true;
        }

        private void btnTmbh_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            opr = 4;
            opr_seleksi = true;
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            if (opr_seleksi == true)
                bil2 = Convert.ToDecimal(textBox1.Text);
            {
                switch (opr)
                {
                    case 1:
                        textBox1.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        textBox1.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        textBox1.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        textBox1.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                opr_seleksi = false;
            }
        }
    }
}
