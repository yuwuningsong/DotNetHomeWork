using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double result;
                double numOne = double.Parse(textNumOne.Text);
                double numTwo = double.Parse(textNumTwo.Text);
                string calculator = comboCal.Text;

                switch (calculator)
                {
                    case "+": result = numOne + numTwo; break;
                    case "-": result = numOne - numTwo; break;
                    case "*": result = numOne * numTwo; break;
                    case "/": result = numOne / numTwo; break;
                    default: labelResult.Text = "请选择运算符！"; return;
                }

                labelResult.Text = "结果是：" + result.ToString();
            }
            catch (Exception ex)
            {
                labelResult.Text = "Exception: " + ex.Message;
            }
        }
    }
}
