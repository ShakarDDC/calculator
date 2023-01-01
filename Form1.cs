using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc2
{
    public partial class Form1 : Form
    {
        string input = string.Empty;        //user input
        String operand1 = string.Empty;     //first num
        String operand2 = string.Empty;     //second num
        char operation;                     //operator
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            input += ".";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '%')
            {
                result = num1 % num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '!')
            {
                result = factorial(num1);
                textBox1.Text = result.ToString();
            }
            else if (operation == '^')
            {
                result = Math.Pow(num1,num2);
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "ERROR DIVIDED BY ZERO";
                }
            }
        }
        public double factorial(double x)
        {
            int i, fact = 1;
            for (i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        private void factorialButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '!';
            input = string.Empty;
        }

        private void buttonReminder_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '%';
            input = string.Empty;
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '^';
            input = string.Empty;
        }
    }
}
