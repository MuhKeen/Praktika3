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
   
    private void button1_Click(object sender, EventArgs e)
     {
      double x = Convert.ToDouble(textBox1.Text);
      textBox2.Text = "Результат задания 3 программы Минакова Н.Д." + Environment.NewLine;
      textBox2.Text += "X = " + textBox1.Text + Environment.NewLine;
      int n = 0;
      if (radioButton2.Checked) n = 1;
      else if (radioButton3.Checked) n = 2;
      double y;
      switch (n)
      {
        case 0:
          if (x < 0) y = -1;
          else if ((x >= 0) && (x < 5)) y = 2 * Math.Sinh(x);
          else y = Math.Sinh(x);
          textBox2.Text += "Y = " + Convert.ToString(y) + Environment.NewLine;
          break;
        case 1:
          if (x < 0) y = -1;
          else if ((x >= 0) && (x < 5)) y = 2 * Math.Cosh(x);
          else y = Math.Cosh(x);
          textBox2.Text += "Y = " + Convert.ToString(y) + Environment.NewLine;
          break;
        case 2:
          if (x < 0) y = -1;
          else if ((x >= 0) && (x < 5)) y = 2 * Math.Exp(x);
          else y = Math.Exp(x);
          textBox2.Text += "Y = " + Convert.ToString(y) + Environment.NewLine;
          break;
        default:
          textBox2.Text += "Не решено" + Environment.NewLine;
          break;
      }

     }
    }
}
