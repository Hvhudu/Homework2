using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    num2 = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case 2:
                    num2 = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case 3:
                    num2 = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case 4:
                    num2 = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case 5:
                    num2 = Math.Sqrt(num1);
                    textBox1.Text = num2.ToString();
                    break;

                default:
                    break;
            }

        }
        double num1, num2;
        int count;
        bool znak;
        public Form1()
        {
            InitializeComponent();
        }

        private void but_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void but_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void but_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void but_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void but_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void but_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void but_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void but_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void but_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void but_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void but_znak_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '.';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void but_plus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = num1.ToString() + "+";
            znak = true;
        }

        private void but_minus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = num1.ToString() + "-";
            znak = true;
        }

        private void but_mult_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = num1.ToString() + "*";
            znak = true;
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = num1.ToString() + "/";
            znak = true;
        }

        private void but_res_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void but_sqrt_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = num1.ToString();
            znak = true;
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
    }
}
