using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_calculator_app
{
    public partial class Form1 : Form
    {
        double resultVal = 0;
        string operationPerformed = "";
        bool hasPerformed = false;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || hasPerformed)
            {
                txtResult.Clear();
            }
            hasPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text = txtResult.Text + button.Text;
                }
            }
            else 
                txtResult.Text = txtResult.Text + button.Text;

        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            hasPerformed = true;
            resultVal = Convert.ToDouble(txtResult.Text);
            lblCrntOperation.Text = resultVal + " " + operationPerformed;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtResult.Text = (resultVal + Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (resultVal - Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (resultVal * Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (resultVal / Convert.ToDouble(txtResult.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultVal = Convert.ToDouble(txtResult.Text);
            lblCrntOperation.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultVal = 0;
        }
    }
}
