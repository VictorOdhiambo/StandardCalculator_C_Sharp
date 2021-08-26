using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorUI : Form
    {
        static double DEFAULT_VALUE = -1234567798.90434;
        double num1 = DEFAULT_VALUE;
        double num2 = DEFAULT_VALUE;
        string sign = "+";
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text = (textBox.Text == "0") ? "0" : textBox.Text += 0;
            return;

        }

        private void btnPnt_Click(object sender, EventArgs e)
        {
            textBox.Text = (textBox.Text.Contains(".")) ? textBox.Text : textBox.Text += ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                textBox.Text = (textBox.Text == "0") ? "1" : textBox.Text += 1;
                return;
            }
            textBox.Text = (textBox.Text == num1 + "") ? "1" : textBox.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                textBox.Text = (textBox.Text == "0") ? "2" : textBox.Text += 2;
                return;
            }
            textBox.Text = (textBox.Text == num1 + "") ? "2" : textBox.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                textBox.Text = (textBox.Text == "0") ? "3" : textBox.Text += 3;
                return;
            }
            textBox.Text = (textBox.Text == num1 + "") ? "3" : textBox.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                textBox.Text = (textBox.Text == "0") ? "4" : textBox.Text += 4;
                return;
            }
            textBox.Text = (textBox.Text == num1 + "") ? "4" : textBox.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                textBox.Text = (textBox.Text == "0") ? "5" : textBox.Text += 5;
                return;
            }
            textBox.Text = (textBox.Text == num1 + "") ? "5" : textBox.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                textBox.Text = (textBox.Text == "0") ? "6" : textBox.Text += 6;
                return;
            }
            textBox.Text = (textBox.Text == num1 + "") ? "6" : textBox.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                textBox.Text = (textBox.Text == "0") ? "7" : textBox.Text += 7;
                return;
            }
            textBox.Text = (textBox.Text == num1 + "") ? "7" : textBox.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                textBox.Text = (textBox.Text == "0") ? "8" : textBox.Text += 8;
                return;
            }
            textBox.Text = (textBox.Text == num1 + "") ? "8" : textBox.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                textBox.Text = (textBox.Text == "0") ? "9" : textBox.Text += 9;
                return;
            }
            textBox.Text = (textBox.Text == num1 + "") ? "9" : textBox.Text += 9;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                double output = calculate(0, 0, "+");
                textBox.Text = output.ToString();
            }
            else if (num1 != DEFAULT_VALUE && num2 == DEFAULT_VALUE)
            {
                num2 = double.Parse(textBox.Text);
                double output = calculate(num1, num2, sign);
                textBox.Text = output.ToString();
                num1 = output;
                num2 = DEFAULT_VALUE;
            }
            else
            {
                double output = calculate(num1, num2, sign);
                textBox.Text = output.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (num1 == DEFAULT_VALUE)
            {
                num1 = double.Parse(textBox.Text);
            }
            else if (num1 != DEFAULT_VALUE && num2 == DEFAULT_VALUE)
            {
                num2 = double.Parse(textBox.Text);
            }
            if (num1 != DEFAULT_VALUE && num2 != DEFAULT_VALUE)
            {
                double sum = calculate(num1, num2, sign);
                textBox.Text = sum + "";
                num1 = sum;
                num2 = DEFAULT_VALUE;
            }
            sign = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                num1 = double.Parse(textBox.Text);
            }
            else if (num1 != DEFAULT_VALUE && num2 == DEFAULT_VALUE)
            {
                num2 = double.Parse(textBox.Text);
            }
            if (num1 != DEFAULT_VALUE && num2 != DEFAULT_VALUE)
            {
                double diff = calculate(num1, num2, sign);
                textBox.Text = diff + "";
                num1 = diff;
                num2 = DEFAULT_VALUE;
            }
            sign = "-";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                num1 = double.Parse(textBox.Text);
            }
            else if (num1 != DEFAULT_VALUE && num2 == DEFAULT_VALUE)
            {
                num2 = double.Parse(textBox.Text);
            }
            if (num1 != DEFAULT_VALUE && num2 != DEFAULT_VALUE)
            {
                double sum = calculate(num1, num2, sign);
                textBox.Text = sum + "";
                num1 = sum;
                num2 = DEFAULT_VALUE;
            }
            sign = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (num1 == DEFAULT_VALUE)
            {
                num1 = double.Parse(textBox.Text);
            }
            else if (num1 != DEFAULT_VALUE && num2 == DEFAULT_VALUE)
            {
                num2 = double.Parse(textBox.Text);
            }
            if (num1 != DEFAULT_VALUE && num2 != DEFAULT_VALUE)
            {
                double sum = calculate(num1, num2, sign);
                textBox.Text = sum + "";
                num1 = sum;
                num2 = DEFAULT_VALUE;
            }
            sign = "/";
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            if (text.Equals("") || text.Equals("0"))
            {
                textBox.Text = "0";
                return;
            }
            textBox.Text = text.Substring(0, text.Length - 1);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            num1 = DEFAULT_VALUE;
            num2 = DEFAULT_VALUE;
        }

        private double calculate(double num1, double num2, string sign)
        {
            double output = 0.0;
            switch (sign)
            {
                case "+":
                    output = num1 + num2;
                    break;
                case "-":
                    output = num1 - num2;
                    break;
                case "*":
                    output = num1 * num2;
                    break;
                case "/":
                    output = num1 / num2;
                    break;
            }
            return output;
        }
    }


}
