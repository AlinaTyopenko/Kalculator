using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);
            string calculationName = ((Button)sender).Name;
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(calculationName);
            double result = calculator.Calculate(first, second);
            label1.Text = Convert.ToString(result);
        }
        private void ClickOne(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            string calculationName = ((Button)sender).Name;
            IOneCalculation calculator = OneCalculation.CreateCalculator(calculationName);
            double result = calculator.Calculate(first);
            label1.Text = Convert.ToString(result);
        }

    }
}
