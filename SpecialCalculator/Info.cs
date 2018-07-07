using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace SpecialCalculator
{
    public partial class Info : Form
    {
        string number;
        public Info(string s)
        {
            number = s;
            InitializeComponent();
            label1.Text = "Information about the number\n" + number;
            checkPrime();
            checkSquare();
        }


        private void checkPrime()
        {
            try
            {
                long n = Convert.ToInt64(number);
                checkedListBox1.SetItemChecked(0, true);
                for (int i=2;i<=System.Math.Sqrt(n);i++)
                {
                    if(n%i==0)
                    {
                        checkedListBox1.SetItemChecked(0, false);
                        break;
                    }
                }
                if(n<2)
                    checkedListBox1.SetItemChecked(0, false);
            }
            catch(Exception e)
            {
                Console.WriteLine("The number is not accepted");
                checkedListBox1.SetItemChecked(0, false);
            }
        }

        private void checkSquare()
        {
            try
            {
                long n = Convert.ToInt64(number);
                double sqrt = System.Math.Sqrt(n);
                checkedListBox1.SetItemChecked(3, Math.Abs(Math.Ceiling(sqrt) - Math.Floor(sqrt)) < Double.Epsilon);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number is not accepted");
                checkedListBox1.SetItemChecked(3, false);
            }
        }
    }
}
