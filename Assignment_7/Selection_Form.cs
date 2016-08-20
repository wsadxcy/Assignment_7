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
            
            _assignCategory();

        }
        private void _assignCategory()
        {

            if (SelectBox.Text == "Seasons of the Witch")
            {
                TitleTextBox.Text = "Seasons of the Witch";
                CategoryTextBox.Text = "Sci-Fi";
            }
            else
            if (SelectBox.Text == "The Green Hornet")
            {
                TitleTextBox.Text = "The Green Hornet";
                CategoryTextBox.Text = "Action";
            }
            else
            if (SelectBox.Text == "The Dilemma")
            {
                TitleTextBox.Text = "The Dilemma";
                CategoryTextBox.Text = "Comedy";
            }
            else
            if (SelectBox.Text == "Death Race 2")
            {
                TitleTextBox.Text = "Death Race 2";
                CategoryTextBox.Text = "Action";
            }
            else
            if (SelectBox.Text == "Company Men")
            {
                TitleTextBox.Text = "Company Men";
                CategoryTextBox.Text = "Drama";
            }
            else
            if (SelectBox.Text == "No Strings Attached")
            {
                TitleTextBox.Text = "No Strings Attached";
                CategoryTextBox.Text = "Comedy";
            }
            else
            if (SelectBox.Text == "The Way Back")
            {
                TitleTextBox.Text = "The Way Back";
                CategoryTextBox.Text = "Drama";
            }
            else
            if (SelectBox.Text == "The Mechanic")
            {
                TitleTextBox.Text = "The Mechanic";
                CategoryTextBox.Text = "Action";
            }
            else
            if (SelectBox.Text == "The Rite")
            {
                TitleTextBox.Text = "The Rite";
                CategoryTextBox.Text = "Horror";
            }
            else
            if (SelectBox.Text == "Sanctum")
            {
                TitleTextBox.Text = "Sanctum";
                CategoryTextBox.Text = "Action";
            }
            else
            if (SelectBox.Text == "The Other Woman")
            {
                TitleTextBox.Text = "The Other Woman";
                CategoryTextBox.Text = "Action";
            }
            else
            if (SelectBox.Text == "The Roommate")
            {
                TitleTextBox.Text = "The Roommate";
                CategoryTextBox.Text = "Thriller";
            }
            else
            if (SelectBox.Text == "Waiting for Forever")
            {
                TitleTextBox.Text = "Waiting for Forever";
                CategoryTextBox.Text = "Drama";
            }
            else
            if (SelectBox.Text == "Cedar Rapids")
            {
                TitleTextBox.Text = "Cedar Rapids";
                CategoryTextBox.Text = "Comedy";
            }
            else
            if (SelectBox.Text == "Gnomeo and Juliet")
            {
                TitleTextBox.Text = "Gnomeo and Juliet";
                CategoryTextBox.Text = "Family";
            }
            else
            if (SelectBox.Text == "Just Go With It")
            {
                TitleTextBox.Text = "Just Go With It";
                CategoryTextBox.Text = "Comedy";
            }
            else
            if (SelectBox.Text == "The Eagle")
            {
                TitleTextBox.Text = "The Eagle";
                CategoryTextBox.Text = "Action";
            }
            else
            if (SelectBox.Text == "I am Number Four")
            {
                TitleTextBox.Text = "I am Number Four";
                CategoryTextBox.Text = "Sci-Fi ";
            }
            else
            if (SelectBox.Text == "Footloose")
            {
                TitleTextBox.Text = "Footloose";
                CategoryTextBox.Text = "New Release";
            }
            else
            if (SelectBox.Text == "Real Steel")
            {
                TitleTextBox.Text = "Real Steel";
                CategoryTextBox.Text = "New Release";
            }

        }
        private void _assignPrice()
        {
            if (CategoryTextBox.Text == "Comedy")
            {
                CostTextBox.Text = "$1.99";
            }
            else if (CategoryTextBox.Text == "Drama")
            {
                CostTextBox.Text = "$1.99";
            }
            else if (CategoryTextBox.Text == "Action")
            {
                CostTextBox.Text = "$2.99";
            }
            else if (CategoryTextBox.Text == "Sci-Fi")
            {
                CostTextBox.Text = "$2.99";
            }
            else if (CategoryTextBox.Text == "Horror")
            {
                CostTextBox.Text = "$2.99";
            }
            else if (CategoryTextBox.Text == "Thriller")
            {
                CostTextBox.Text = "$1.99";
            }
            else if (CategoryTextBox.Text == "Family")
            {
                CostTextBox.Text = "$0.99";
            }
            else if (CategoryTextBox.Text == "New Releases")
            {
                CostTextBox.Text = "$4.99";
            }
        }


    }

    }

