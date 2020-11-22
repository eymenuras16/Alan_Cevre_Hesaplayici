using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Hesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, çevre;

            birkenar = Convert.ToInt32(textBox1.Text);

            alan = birkenar * birkenar;
            çevre = 4 * birkenar;

            label4.Text = alan.ToString();
            label5.Text = çevre.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Text = "KARE";
            button3.Visible = true;
            button5.Visible = false;
            button4.Visible = true;
            label1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label1.Visible = false;
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "DİKDÖRTGEN";
            label2.Text = "Kısa Kenar";
            label7.Visible = true;
            textBox2.Visible = true;
            panel1.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = true;
            label1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int alan1, çevre1;
            int uzun, kısa;

            uzun = Convert.ToInt32(textBox1.Text);
            kısa = Convert.ToInt32(textBox2.Text);

            alan1 = kısa * uzun;
            çevre1 = (2 * kısa) + (2 * uzun);

            label4.Text = alan1.ToString();
            label5.Text = çevre1.ToString();
        }
    }
}
