using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork1
{
    public partial class Form1 : Form

    {
        private int totalInvoices = 0;
        private decimal totalInvoiceValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtEnterSubtotal.Text, out decimal subtotal))
            {
                decimal discountPercent = 0.25m; 
                decimal discountAmount = subtotal * discountPercent;
                decimal total = subtotal - discountAmount;

                txtSubtotal.Text = subtotal.ToString("C2");
                txtDiscountPercent.Text = (discountPercent * 100).ToString("F1") + "%";
                txtDiscountAmount.Text = discountAmount.ToString("C2");
                txtTotal.Text = total.ToString("C2");

                totalInvoices++;
                totalInvoiceValue += total;

                txtNumberOfInvoices.Text = totalInvoices.ToString();
                txtTotalOfInvoices.Text = totalInvoiceValue.ToString("C2");
                txtInvoiceAverage.Text = (totalInvoiceValue / totalInvoices).ToString("C2");
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value for the subtotal.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            totalInvoices = 0;
            totalInvoiceValue = 0;

            txtNumberOfInvoices.Text = "0";
            txtTotalOfInvoices.Text = "$0.00";
            txtInvoiceAverage.Text = "$0.00";

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
