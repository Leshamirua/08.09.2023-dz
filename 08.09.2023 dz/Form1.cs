using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08._09._2023_dz
{
    public partial class Form1 : Form
    {
        public string Operation;
        public string NumberUser;
        public bool Check;
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Check){
                Check = false;
                textBox1.Text = "0";

            }
            Button NumButt=(Button)sender;
           
            if (textBox1.Text == "0")
                textBox1.Text = NumButt.Text;
            else
                textBox1.Text = textBox1.Text + NumButt.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            Button NumButt = (Button)sender;
            Operation = NumButt.Text;
            NumberUser = textBox1.Text;
            Check = true;
        }

        private void button_eql_Click(object sender, EventArgs e)
        {
            double d_NumberUser1, d_NumberUser2, Result;
            Result = 0;
            d_NumberUser1 = Convert.ToDouble(NumberUser);
            d_NumberUser2 = Convert.ToDouble(textBox1.Text);
            if(Operation == "+")
            {
                Result = d_NumberUser1 + d_NumberUser2;
            }
            else if (Operation == "-")
            {
                Result = d_NumberUser1 - d_NumberUser2;
            }
            else if (Operation == "х")
            {
                Result = d_NumberUser1 * d_NumberUser2;
            }
            else if (Operation == "/")
            {
                Result = d_NumberUser1 / d_NumberUser2;
            }
            else if (Operation == "%")
            {
                Result = d_NumberUser1 * d_NumberUser2 / 100;
            }
            Operation = "=";
            Check = true;
            textBox1.Text= Result.ToString();
        }

        private void button_root_Click(object sender, EventArgs e)
        {
            double  Num, Result;
            Num = Convert.ToDouble(textBox1.Text); 
            Result = Math.Sqrt(Num);
            textBox1 .Text = Result.ToString();
        }

        private void button_double_Click(object sender, EventArgs e)
        {
            double Num, Result;
            Num = Convert.ToDouble(textBox1.Text);
            Result = Math.Pow(Num, 2);
            textBox1.Text = Result.ToString();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            double Num, Result;
            Num = Convert.ToDouble(textBox1.Text);
            Result = -Num;
            textBox1.Text = Result.ToString();
        }

        private void button_coma_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
            textBox1.Text = textBox1.Text + ",";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
    }
}
