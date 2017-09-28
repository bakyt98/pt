using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Sqrt(Double.Parse(textBox1.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number;
            number = button1.Text;
            textBox1.AppendText(number);
             
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string number;
            number = button12.Text;
            textBox1.AppendText(number);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            string number;
            number = button2.Text;
            textBox1.AppendText(number);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string number;
            number = button3.Text;
            textBox1.AppendText(number);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string number;
            number = button4.Text;
            textBox1.AppendText(number);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string number;
            number = button5.Text;
            textBox1.AppendText(number);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string number;
            number = button6.Text;
            textBox1.AppendText(number);
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string number;
            number = button7.Text;
            textBox1.AppendText(number);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string number;
            number = button8.Text;
            textBox1.AppendText(number);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string number;
            number = button9.Text;
            textBox1.AppendText(number);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            calculate();
            

    }
        private void calculate()
        {
            double result=0;
            int j = 0;
            String s = textBox1.Text;
            String[] numbers= s.Split('+', '-', '*', '/');
            String[] operations = s.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
            for (int i = 0; i < operations.Length; i++) {
                if (operations[i] == "+") {
                    result = Convert.ToDouble(numbers[j]) + Convert.ToDouble(numbers[j + 1]);
                    numbers[j + 1] = Convert.ToString(result);
                    j++;
                }
                if (operations[i] == "-") {
                    result = Convert.ToDouble(numbers[j]) - Convert.ToDouble (numbers[j + 1]);
                    numbers[j + 1] = Convert.ToString(result);
                    j++;
                }
                if (operations[i] == "*")
                {
                    result = Convert.ToDouble(numbers[j]) * Convert.ToDouble(numbers[j + 1]);
                    numbers[j + 1] = Convert.ToString(result);
                    j++;
                }
                if (operations[i] == "/")
                {
                    result = Convert.ToDouble(numbers[j]) / Convert.ToDouble(numbers[j + 1]);
                    numbers[j + 1] = Convert.ToString(result);
                    j++;
                }
            }
            textBox1.Text = Convert.ToString(result);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string number;
            number = button13.Text;
            textBox1.AppendText(number);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string number;
            number = button14.Text;
            textBox1.AppendText(number);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string number;
            number = button15.Text;
            textBox1.AppendText(number);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            catch (Exception) { }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            string number;
            number = button25.Text;
            textBox1.AppendText(number);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text),2));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(1 /( Convert.ToDouble(textBox1.Text)));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            /* String expression = textBox1.Text;
             String pattern = @"(\d+)+([*-+])+(\d+)";

             foreach (Match m in Regex.Matches(expression, pattern))
             {
                 int value1 = Int32.Parse(m.Groups[1].Value);
                 int value2 = Int32.Parse(m.Groups[3].Value);
                 switch (m.Groups[2].Value) {
                     case "*": {


                             textBox1.Text = Convert.ToString(value1 * value2 / 100);
                             break;
                         }
                     case "-": {
                             textBox1.Text = Convert.ToString(value1 - (value1 * value2 / 100));
                             break;
                         }
                     case "+":
                         {
                             textBox1.Text = Convert.ToString(value1 + (value1 * value2 / 100));
                             break;
                         }
                 }*/
            double result = 0;
            int j = 0;
            String s = textBox1.Text;
            String[] numbers = s.Split('+', '-', '*');
            String[] operations = s.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "+")
                {
                    result = Convert.ToDouble(numbers[j]) + Convert.ToDouble(numbers[j])*Convert.ToDouble(numbers[j + 1])/100;
                    numbers[j + 1] = Convert.ToString(result);
                    j++;
                }
                if (operations[i] == "-")
                {
                    result = Convert.ToDouble(numbers[j]) - Convert.ToDouble(numbers[j])*Convert.ToDouble(numbers[j + 1])/100;
                    numbers[j + 1] = Convert.ToString(result);
                    j++;
                }
                if (operations[i] == "*")
                {
                    result = Convert.ToDouble(numbers[j]) * Convert.ToDouble(numbers[j + 1])/100;
                    numbers[j + 1] = Convert.ToString(result);
                    j++;
                }
                
            }
            textBox1.Text = Convert.ToString(result);




        
        
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt16(textBox1.Text);
            number = number * (-1);
            if (number == 0) textBox1.Text="0";
            else textBox1.Text=Convert.ToString(number);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string number;
            number = button26.Text;
            textBox1.AppendText(number);
        }
        int? memory;
        private void button24_Click(object sender, EventArgs e)
        {
            memory = Convert.ToInt16(textBox1.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            memory = null;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text=Convert.ToString(memory);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt16(textBox1.Text);
        
            textBox1.Text = Convert.ToString(number + memory);
            memory = number + memory;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt16(textBox1.Text);
            textBox1.Text = Convert.ToString(number - memory);
            memory = number - memory;
        }
    }
}
