using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIZILER_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 234, 343, 24, 354, 2434, 353, 25, 576,-234,-4567,-123 };
            foreach(int number in numbers)
            {
                if (number % 3 == 0&&number <0)
                {
                    listBox1.Items.Add(number);
                }
            }
        }
    }
}
