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
            switch(((Button)sender).Name)
          {
           case "button1":
		      label1.Text = Convert.ToString(first + second);
		      break;
	       case "button2":
              label1.Text = Convert.ToString(first - second);
		      break;
           case "button3":
              label1.Text = Convert.ToString(first * second);
              break;
           case "button4":
              label1.Text = Convert.ToString(first / second);
              break;
	       default:
		   throw new Exception("Неизвестная операция");
          }

        }

    }
}
