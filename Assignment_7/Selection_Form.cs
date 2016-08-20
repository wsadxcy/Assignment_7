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
    public partial class SelectionForm : Form
    {
        List<string> MovieDetail = new List<string>();


        private void SelectMovie()
        {
            MovieDetail.Add(TitleTextBox.Text);
            MovieDetail.Add(CategoryTextBox.Text);
            MovieDetail.Add(CostTextBox.Text);
        }

        public SelectionForm()
        {
            InitializeComponent();
        }

        private void SelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBox.SelectedItem = TitleTextBox.Text;
            assignCategory();

        }
        private void assignCategory()
        {
            switch(SelectBox.Items.Count)
            {
                case 1 :
                    if(TitleTextBox.Text == "Season of the Witch")
                    {
                        CategoryTextBox.Text = "Sci-Fi";
                    }
                    break;
                case 2:
                    if (TitleTextBox.Text == "The Green Hornet")
                    {
                        CategoryTextBox.Text = "Action";
                    }
                    break;
                case 3:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 4:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 5:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 6:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 7:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 8:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 9:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 10:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 11:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 12:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 13:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 14:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 15:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 16:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 17:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 18:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 19:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
                case 20:
                    if (TitleTextBox.Text == "Cedar Rapids")
                    {
                        CategoryTextBox.Text = "Comedy";
                    }
                    break;
            }
        }

    }
}
