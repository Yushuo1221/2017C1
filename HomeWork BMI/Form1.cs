using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_BMI
{
    public partial class Form1 : Form
    {
        private BMI _data;
        public Form1()
        {
            InitializeComponent();
            _data = new BMI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _data.Height = double.Parse(textBox1.Text);
            _data.Weight = double.Parse(textBox2.Text);

            double a = _data.add();

            if(a <= 18.5)
            {
                label3.Text = "BMI: " + _data.add().ToString("#0.0") + "  過瘦";
            }

            if(a>=18.5 && a<24)
            {
                label3.Text ="BMI: "+ _data.add().ToString("#0.0") + "  正常";
            }

            if(a>=24 && a<27)
            {
                label3.Text = "BMI: " + _data.add().ToString("#0.0") + "  過重";
            }

            if (a >=27 && a < 30)
            {
                label3.Text = "BMI: " + _data.add().ToString("#0.0") + "  輕度肥胖";
            }

            if (a >=30 && a < 35)
            {
                label3.Text = "BMI: " + _data.add().ToString("#0.0") + "  中度肥胖";
            }

            if (a >=35 )
            {
                label3.Text = "BMI: " + _data.add().ToString("#0.0") + "  過度肥胖";
            }
        }
    }
}
