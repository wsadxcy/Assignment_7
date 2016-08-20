using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Order_Form : Form
    {
        private SelectionForm _sf;
        public double Cost;
        

        public Order_Form()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionForm selectionform = new SelectionForm();
            selectionform.Show();
        }

        private void Stream_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stream_Form streamform = new Stream_Form();
            streamform.label3.Text = this.TitleTextBox.Text + " will be begin streaming shortly.";
            streamform.label2.Text = "Your cridit card will be charged " + this.GrandTotalTextBox.Text;
            streamform.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.Show();
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {
            this.TitleTextBox.Text = _sf.TitleTextBox.Text;
        }

        private void Category_TextChanged(object sender, EventArgs e)
        {
            this.CategoryTextBox.Text = _sf.CategoryTextBox.Text;
        }

        private void Order_Form_Load(object sender, EventArgs e)
        {
            CostTextBox.Text = Cost.ToString();
            SubTotalTextBox.Text = Cost.ToString();
            double tax = Cost * 0.13;
            SaleTaxTextBox.Text = tax.ToString();
            double grand = tax + Cost;
            GrandTotalTextBox.Text = grand.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionForm selectionform = new SelectionForm();
            selectionform.Show();
            selectionform.TitleTextBox.Text = this.TitleTextBox.Text;
            selectionform.CategoryTextBox.Text = this.CategoryTextBox.Text;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            CostTextBox.Text = Cost.ToString();
        }

        private void SubTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            SubTotalTextBox.Text = Cost.ToString();
        }

        private void SaleTaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrandTotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderDVD_CheckedChanged(object sender, EventArgs e)
        {
            if (OrderDVD.Checked)
            {
                DVDTextBox.Visible = true;
                label7.Visible = true;
            }
        }
    }
}
