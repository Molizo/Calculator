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
            checkFibonacci();
            checkPalindrome();
            checkSquare();
            checkCube();
            checkPositive();
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
                if (n < 0)
                    checkedListBox1.SetItemChecked(3, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number is not accepted");
                checkedListBox1.SetItemChecked(3, false);
            }
        }

        private void checkCube()
        {
            try
            {
                long n = Convert.ToInt64(number);
                double sqrt = System.Math.Pow(n,1.0/3.0);
                checkedListBox1.SetItemChecked(4, Math.Abs(Math.Ceiling(sqrt) - Math.Floor(sqrt)) < Double.Epsilon);
                if (n < 0)
                    checkedListBox1.SetItemChecked(4, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number is not accepted");
                checkedListBox1.SetItemChecked(4, false);
            }
        }

        private void checkPositive()
        {
            checkedListBox1.SetItemChecked(5, !(number.Contains("-")));
        }

        private void checkPalindrome()
        {
            try
            {
                long n = Convert.ToInt64(number);
                long m,reverse;
                m = n;
                reverse = 0;
                while(m > 0)
                {
                    reverse = reverse * 10 + m % 10;
                    m /= 10;
                }
                checkedListBox1.SetItemChecked(2, n == reverse);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number is not accepted");
                checkedListBox1.SetItemChecked(4, false);
            }
        }

        private void checkFibonacci()
        {
            try
            {
                long n = Convert.ToInt64(number);
                long a = 0, b = 1;
                while(a<n)
                {
                    long temp = a;
                    a = b;
                    b = temp + b;
                }
                checkedListBox1.SetItemChecked(1, a == n);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number is not accepted");
                checkedListBox1.SetItemChecked(1, false);
            }
        }
    }
}
