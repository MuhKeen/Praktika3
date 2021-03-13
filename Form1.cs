using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    double MF(double x, double xmod)
    {
      double y;
      if (x < 0) y = -1;
      else if ((x >= 0) && (x < 5)) y = 2 * xmod;
      else y = xmod;
      return y;
    }
    private void button1_Click(object sender, EventArgs e)
    {
      double x = Convert.ToDouble(textBox1.Text);
      int n = 0;
      if (radioButton2.Checked) n = 1;
      else if (radioButton3.Checked) n = 2;
      double xmod = 0;
      switch (n)
      {
        case 0:
          xmod = Math.Sinh(x);
          break;
        case 1:
          xmod = Math.Cosh(x);
          break;
        case 2:
          xmod = Math.Exp(x);
          break;
        default:
          break;
      }
      textBox2.Text = "Результат задания 3 программы Минакова Н.Д." + Environment.NewLine;
      textBox2.Text += "X = " + textBox1.Text + Environment.NewLine;
      textBox2.Text += "Y = " + MF(x,xmod) + Environment.NewLine;
    }
  }
}
