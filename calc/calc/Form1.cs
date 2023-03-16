using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calc
{
    public partial class Form1 : Form
    {
        public string action;
        public string FirstNum;
        public bool TurnToSecond;
        public Form1()
        {
            TurnToSecond = false;
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(32,32,32);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num, answer = 0;
            num = Convert.ToDouble(textBox1.Text);
            answer = num * num;
            textBox1.Text = answer.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            FirstNum = textBox1.Text;
            TurnToSecond = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {   if(!textBox1.Text.Contains(","))
            textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double num,answer=0;
            num = Convert.ToDouble(textBox1.Text);
            answer = Math.Sqrt(num);
            textBox1.Text = answer.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double num, answer = 0;
            num = Convert.ToDouble(textBox1.Text);
            answer = -num;
            textBox1.Text = answer.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (TurnToSecond)
            {
                TurnToSecond = false;
                textBox1.Text = "0";
            }

            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num, answer = 0;
            num = Convert.ToDouble(textBox1.Text);
            answer = 1 / num;
            textBox1.Text = answer.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            FirstNum = textBox1.Text;
            TurnToSecond = true;

        }
        private void button24_Click(object sender, EventArgs e)
        {
            double num1, num2,answer;
            answer = 0;
            num1 = Convert.ToDouble(FirstNum);
            num2 = Convert.ToDouble(textBox1.Text);
            if (action == "+")
            {
                answer = num1 + num2;
            }
            if (action == "-")
            {
                answer = num1 - num2;
            }
            if (action == " ×")
            {
                answer = num1 * num2;
            }
            if (action == "÷")
            {
                answer = num1 / num2;
            }

            if (action == "%")
            {
                answer = num1 * num2 / 100;
            }

            action = "=";
            textBox1.Text = answer.ToString();
        }
    }
}
