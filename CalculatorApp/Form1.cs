using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
           
            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text += textBox_Result.Text + button.Text;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;

        }
       
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            { //double.parse عشان هعمل عمليات حسابية بأرقام عشرية وعشان النتائج العشرية برضو

                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                    
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            operationPerformed = "";
            isOperationPerformed = true;
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text != "0")
            {
                double Value = Double.Parse(textBox_Result.Text);
                Value = -Value;
                textBox_Result.Text = Value.ToString();
            }
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text.Length > 0)
            {
                textBox_Result.Text = textBox_Result.Text.Remove(textBox_Result.Text.Length - 1);
                if (textBox_Result.Text == "")
                {
                    textBox_Result.Text = "0";
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        
        }
    }
    
    
