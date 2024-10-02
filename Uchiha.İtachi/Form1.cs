using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uchiha.İtachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1;
            s1 = Convert.ToInt32(textBox1.Text);
            if (s1 < 0)
            {
                label2.Text = s1+" Negatif Sayı";
            }
            if (s1 >= 0)
            {
                label2.Text = s1+" Pozitif Sayı";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox2.Text);
            if (s1%2==1)
            {
                label3.Text = s1 + " Tek Sayıdır";
            }
            if (s1%2==0)
            {
                label3.Text = s1 + " Çift Sayıdır";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dYili, yil, yas;
            dYili = Convert.ToInt32(textBox3.Text);
            yil = DateTime.Now.Year;
            yas = yil - dYili;
            if (yas<18)
            {
                label5.Text = yas + " Yaşındasınız Ehliyet için Yaşınız Yetmiyor";
            }
            else
            {
                label5.Text = yas + " Yaşındasınız Ehliyet için Yaşınız Yetiyor";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox4.Text);
            if (s1 % 10 == 0)
            {
                label7.Text = s1 + " 10'a Tam Bölünür";
            }
            else
            {
                label7.Text = s1 + " 10'a Tam Bölünemez";
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
                    }

        private void button5_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            if (checkBox1.Checked)
            {
                listBox1.Items.Add("Lambalar Açık");
            }
            else
            {
                listBox1.Items.Add("Lambalar Kapalı");
            }
            if (checkBox2.Checked)
            {
                listBox1.Items.Add ("Kombi Açık");
            }
            else
            {
                listBox1.Items.Add("Kombi Kapalı");
            }

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int s1, s2,topla,carp;
            s1 = Convert.ToInt32(textBox6.Text);
            s2 = Convert.ToInt32(textBox5.Text);
            topla = s1 + s2;
            carp = s1 * s2;
            if (radioButton1.Checked)
            {
                label11.Text = topla.ToString();
            }
            if (radioButton2.Checked)
            {
                label11.Text = carp.ToString();
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
