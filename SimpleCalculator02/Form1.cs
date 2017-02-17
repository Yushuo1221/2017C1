using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Calculate(1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Calculate(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate(4);
        }

        private void Calculate(int add)
        {
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
           switch(add)
            {
                case 1:
                    label1.Text = (x + y).ToString();
                    break;
                case 2:
                    label1.Text = (x - y).ToString();
                    break;
                case 3:
                    label1.Text = (x * y).ToString();
                    break;
                case 4:
                    label1.Text = (x / y).ToString();
                    break;

              
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            label1.Text = ("0");
        }
    }
}
