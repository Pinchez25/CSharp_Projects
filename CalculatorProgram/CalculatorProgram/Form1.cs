using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //double a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblSec.Text = txtNum2.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                lblOp.Text = "+";

                String a = txtNum1.Text;
                string b = txtNum2.Text;

                if (String.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                {
                    MessageBox.Show("One or more empty fields");
                }
                else
                {
                   
                    double c = double.Parse(a) + double.Parse(b);
                    lblEq.Text = " = ";

                    lblResult.Text = c.ToString();

                    lblAns.Text = lblResult.Text;
                }

                

                
            }
            catch (FormatException) {
                lblEq.Text = "=";
                lblAns.Text = "Error";
                lblResult.Text = "Error";
                //MessageBox.Show("Wrong entry");
            
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                lblOp.Text = "*";

                String a = txtNum1.Text;
                string b = txtNum2.Text;

                if (String.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                {
                    MessageBox.Show("One or more empty fields");
                }
                else
                {

                    double c = double.Parse(a) * double.Parse(b);
                    lblEq.Text = " = ";

                    lblResult.Text = c.ToString();

                    lblAns.Text = lblResult.Text;
                }
            }
            catch (FormatException )
            {
                lblEq.Text = "=";
                lblAns.Text = "Error";
                lblResult.Text = "Error";
                //MessageBox.Show("Wrong entry");
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                lblOp.Text = "-";

                String a = txtNum1.Text;
                string b = txtNum2.Text;

                if (String.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                {
                    MessageBox.Show("One or more empty fields");
                }
                else
                {

                    double c = double.Parse(a) - double.Parse(b);
                    lblEq.Text = " = ";

                    lblResult.Text = c.ToString();

                    lblAns.Text = lblResult.Text;
                }
            }
            catch (FormatException)
            {
                lblEq.Text = "=";
                lblAns.Text = "Error";
                lblResult.Text = "Error";
                //MessageBox.Show("Wrong format");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
               

                lblOp.Text = "/";

                String a = txtNum1.Text;
                string b = txtNum2.Text;

                if (String.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                {
                    MessageBox.Show("One or more empty fields");
                }
                else
                {

                    double c = double.Parse(a) / double.Parse(b);
                    lblEq.Text = " = ";

                    lblResult.Text = c.ToString();

                    lblAns.Text = lblResult.Text;
                }
            }
            catch (FormatException) {
                lblEq.Text = "=";
                lblAns.Text = "Error";
                lblResult.Text = "Error";
                //MessageBox.Show("Wrong entry");
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            lblFirst.Text = txtNum1.Text;
        }
    }
}
