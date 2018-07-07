using NCalc;
using System;
using System.Media;
using System.Windows.Forms;

namespace SpecialCalculator
{
    public partial class Calculator : Form
    {
        private double memory = 0.0F;

        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonMemoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                buttonEquals_Click(sender, e);
                memory += Convert.ToSingle(labelNumber.Text.ToString());
            }
            catch (Exception exception)
            {
                SystemSounds.Asterisk.Play();
                Console.WriteLine("Error while manipulating memory!\n");
                Console.WriteLine("Debugging information follows:");
                Console.WriteLine(exception);
            }
        }

        private void buttonMemorySubstract_Click(object sender, EventArgs e)
        {
            try
            {
                buttonEquals_Click(sender, e);
                memory -= Convert.ToSingle(labelNumber.Text.ToString());
            }
            catch (Exception exception)
            {
                SystemSounds.Asterisk.Play();
                Console.WriteLine("Error while manipulating memory!\n");
                Console.WriteLine("Debugging information follows:");
                Console.WriteLine(exception);
            }
        }

        private void buttonMemoryRead_Click(object sender, EventArgs e)
        {
            labelNumber.Text = memory.ToString();
        }

        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {
            memory = 0.0F;
        }

        private void buttonMemoryStore_Click(object sender, EventArgs e)
        {
            buttonEquals_Click(sender, e);
            memory = Convert.ToSingle(labelNumber.Text.ToString());
        }

        private void buttonClearEverything_Click(object sender, EventArgs e)
        {
            labelOperations.Text = String.Empty;
            labelNumber.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            string text = labelNumber.Text.ToString();
            labelNumber.Text = text.Remove(text.Length - 1);
            if (labelNumber.Text == String.Empty)
                labelNumber.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            else if (labelNumber.Text == "-0")
                labelNumber.Text = "-";
            labelNumber.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            else if (labelNumber.Text == "-0")
                labelNumber.Text = "-";
            labelNumber.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            else if (labelNumber.Text == "-0")
                labelNumber.Text = "-";
            labelNumber.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            else if (labelNumber.Text == "-0")
                labelNumber.Text = "-";
            labelNumber.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            else if (labelNumber.Text == "-0")
                labelNumber.Text = "-";
            labelNumber.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            else if (labelNumber.Text == "-0")
                labelNumber.Text = "-";
            labelNumber.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            else if (labelNumber.Text == "-0")
                labelNumber.Text = "-";
            labelNumber.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            else if (labelNumber.Text == "-0")
                labelNumber.Text = "-";
            labelNumber.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            else if (labelNumber.Text == "-0")
                labelNumber.Text = "-";
            labelNumber.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text != "0")
                labelNumber.Text += "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelOperations.Text += labelNumber.Text + "+";
            labelNumber.Text = "0";
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            labelOperations.Text += labelNumber.Text + "-";
            labelNumber.Text = "0";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            labelOperations.Text += labelNumber.Text + "*";
            labelNumber.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            labelOperations.Text += labelNumber.Text + "/";
            labelNumber.Text = "0";
        }

        private void buttonModulo_Click(object sender, EventArgs e)
        {
            labelOperations.Text += labelNumber.Text + "%";
            labelNumber.Text = "0";
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            labelOperations.Text += "Pow(" + labelNumber.Text + ",";
            labelNumber.Text = "0";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            labelOperations.Text += "Sqrt(" + labelNumber.Text + ")";
            labelNumber.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelNumber.Text != "0")
                    labelOperations.Text += labelNumber.Text;
                Expression operations = new Expression(labelOperations.Text.ToString());
                labelNumber.Text = operations.Evaluate().ToString();
                labelOperations.Text = String.Empty;
            }
            catch (Exception exception)
            {
                SystemSounds.Asterisk.Play();
                Console.WriteLine("Error while processing operations!\n");
                Console.WriteLine("Debugging information follows:");
                Console.WriteLine(exception);
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text.Contains(".") == false)
                labelNumber.Text += ".";
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text.Contains("-") == true)
            {
                string text = labelNumber.Text.ToString();
                labelNumber.Text = text.Remove(0, 1);
            }
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            switch (key)
            {
                case '0':
                    button0_Click(sender, e);
                    break;

                case '1':
                    button1_Click(sender, e);
                    break;

                case '2':
                    button2_Click(sender, e);
                    break;

                case '3':
                    button3_Click(sender, e);
                    break;

                case '4':
                    button4_Click(sender, e);
                    break;

                case '5':
                    button5_Click(sender, e);
                    break;

                case '6':
                    button6_Click(sender, e);
                    break;

                case '7':
                    button7_Click(sender, e);
                    break;

                case '8':
                    button8_Click(sender, e);
                    break;

                case '9':
                    button9_Click(sender, e);
                    break;

                case '.':
                    buttonDecimal_Click(sender, e);
                    break;

                case ',':
                    goto case '.';
                case (char)Keys.Back:
                    buttonBackspace_Click(sender, e);
                    break;

                case '+':
                    buttonAdd_Click(sender, e);
                    break;

                case '-':
                    buttonSubstract_Click(sender, e);
                    break;

                case 'x':
                    goto case '*';
                case 'X':
                    goto case 'x';
                case '*':
                    buttonMultiply_Click(sender, e);
                    break;

                case '÷':
                    buttonDivide_Click(sender, e);
                    break;

                case '/':
                    goto case '÷';
                case ':':
                    goto case '÷';
                case '%':
                    buttonModulo_Click(sender, e);
                    break;

                case '^':
                    buttonPower_Click(sender, e);
                    break;

                case '√':
                    buttonSqrt_Click(sender, e);
                    break;

                case '=':
                    buttonEquals_Click(sender, e);
                    break;

                case '±':
                    buttonPlusMinus_Click(sender, e);
                    break;

                case '(':
                    buttonOpenParenthesis_Click(sender, e);
                    break;

                case ')':
                    buttonCloseParenthesis_Click(sender, e);
                    break;

                case '[':
                    goto case '(';
                case ']':
                    goto case ')';
                case '{':
                    goto case '(';
                case '}':
                    goto case ')';
                default:
                    Console.WriteLine("Invalid key pressed: " + key);
                    SystemSounds.Asterisk.Play();
                    break;
            }
        }

        private void buttonAbsolute_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text.Contains("-") == true)
            {
                string text = labelNumber.Text.ToString();
                labelNumber.Text = text.Remove(0, 1);
            }
        }

        private void buttonOpenParenthesis_Click(object sender, EventArgs e)
        {
            labelOperations.Text += labelNumber.Text + "(";
            labelNumber.Text = "0";
        }

        private void buttonCloseParenthesis_Click(object sender, EventArgs e)
        {
            labelOperations.Text += labelNumber.Text + ")";
            labelNumber.Text = "0";
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info infoWindow = new Info(labelNumber.Text);
            infoWindow.ShowDialog();
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                long n = Convert.ToInt64(labelNumber.Text.ToString());
                if (n > 20)
                {
                    labelNumber.Text = "Too big for !";
                    throw new Exception("Number is too big for factorial.");
                }
                long output = 1;
                for (int i = 2; i <= n; i++)
                    output *= i;
                labelNumber.Text = output.ToString();
            }
            catch (Exception exception)
            {
                SystemSounds.Asterisk.Play();
                Console.WriteLine("Input is not valid!\n");
                Console.WriteLine("Debugging information follows:");
                Console.WriteLine(exception);
            }
        }
    }
}