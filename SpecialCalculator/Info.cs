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
    public partial class Info : Form
    {
        string number;
        public Info(string s)
        {
            number = s;
            InitializeComponent();
            label1.Text = "Information about the number\n" + number;
            checkPrime();
        }

        private void checkPrime()
        {
            long n = Convert.ToInt64(number);
            if (n.ToString() == number)
                checkedListBox1.SetItemChecked(0, true);
            Console.WriteLine(number + "|" + n);
        }
    }
}
