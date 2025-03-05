using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod03_103022300144
{
    public partial class Form1: Form
    {
        private int[] merge;

        private char? plus;
        private char? equals;

        private int x = 0;
        private int sum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {
                x *= 10;
                x += 1;
                lblOutput.Text += x.ToString();
            }
            else
            {
                x = 1;
                lblOutput.Text = x.ToString();
            }

            //string num1 = "1";

            //int converted = Int32.Parse(num1);
            //textBox1.Text = converted.ToString();
            //textBox1.Show();
        }
            

        private void btn2_Click(object sender, EventArgs e)
        {
            //string num2 = "2";
            //int converted = Int32.Parse(num2);
            //textBox1.Text = converted.ToString();
            //textBox1.Show();

            if (x != 0)
            {
                x *= 10;
                x += 2;
                lblOutput.Text += x.ToString();
            }
            else
            {
                x = 2;
                lblOutput.Text = x.ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //string num3 = "3";
            //int converted = Int32.Parse(num3);
            //textBox1.Text = converted.ToString();
            //textBox1.Show();

            if (x != 0)
            {
                x *= 10;
                x += 3;
                lblOutput.Text += x.ToString();
            }
            else
            {
                x = 3;
                lblOutput.Text = x.ToString();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //string num4 = "4";
            //int converted = Int32.Parse(num4);
            //textBox1.Text = converted.ToString();
            //textBox1.Show();

            if (x != 0)
            {
                x *= 10;
                x += 4;
                lblOutput.Text += x.ToString();
            }
            else
            {
                x = 4;
                lblOutput.Text = x.ToString();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //string num5 = "5";
            //int converted = Int32.Parse(num5);
            //textBox1.Text = converted.ToString();
            //textBox1.Show();

            if (x != 0)
            {
                x *= 10;
                x += 5;
                lblOutput.Text += x.ToString();
            }
            else
            {
                x = 5;
                lblOutput.Text = x.ToString();
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //string num6 = "6";
            //int converted = Int32.Parse(num6);
            //textBox1.Text = converted.ToString();
            //textBox1.Show();

            if (x != 0)
            {
                x *= 10;
                x += 6;
                lblOutput.Text += x.ToString();
            }
            else
            {
                x = 6;
                lblOutput.Text = x.ToString();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //string num7 = "7";
            //int converted = Int32.Parse(num7);
            //textBox1.Text = converted.ToString();
            //textBox1.Show();

            if (x != 0)
            {
                x *= 10;
                x += 7;
                lblOutput.Text += x.ToString();
            }
            else
            {
                x = 7;
                lblOutput.Text = x.ToString();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //string num8 = "8";
            //int converted = Int32.Parse(num8);
            //textBox1.Text = converted.ToString();
            //textBox1.Show();

            if (x != 0)
            {
                x *= 10;
                x += 8;
                lblOutput.Text += x.ToString();
            }
            else
            {
                x = 8;
                lblOutput.Text = x.ToString();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //string num9 = "9";
            //int converted = Int32.Parse(num9);
            //textBox1.Text = converted.ToString();
            //textBox1.Show();

            if (x != 0)
            {
                x *= 10;
                x += 9;
                lblOutput.Text += x.ToString();
            }
            else
            {
                x = 9;
                lblOutput.Text = x.ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            sum += x;
            lblOutput.Text = "+";
            x = 0;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {
                x *= 10;
                lblOutput.Text = x.ToString();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (sum == null)
            {
                sum += x;
                lblOutput.Text = sum.ToString();
                x = 0;
                sum = 0;
            }
            else
            {
                sum += x;
                lblOutput.Text = sum.ToString();
            }
        }
    }
}
