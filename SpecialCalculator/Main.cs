using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonMemoryAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonMemorySubstract_Click(object sender, EventArgs e)
        {

        }

        private void buttonMemoryRead_Click(object sender, EventArgs e)
        {

        }

        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonMemoryStore_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearEverything_Click(object sender, EventArgs e)
        {
            labelOperations.Text = String.Empty;
            labelNumber.Text = String.Empty;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = String.Empty;
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
            labelNumber.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            labelNumber.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            labelNumber.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            labelNumber.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            labelNumber.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            labelNumber.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            labelNumber.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            labelNumber.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text == "0")
                labelNumber.Text = String.Empty;
            labelNumber.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text != "0")
                labelNumber.Text += "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivideAbs_Click(object sender, EventArgs e)
        {

        }

        private void buttonModulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonPower_Click(object sender, EventArgs e)
        {

        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if(labelNumber.Text.Contains(".") == false)
                labelNumber.Text += ".";
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
