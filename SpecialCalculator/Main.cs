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
            int CellWidth;
            CellWidth = this.Size.Width / 5;
            InitializeComponent();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
        }
    }
}
