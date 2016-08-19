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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void Splash_Screen_Timer_Tick(object sender, EventArgs e)
        {
            SelectionForm selectionform = new SelectionForm();
            Splash_Screen_Timer.Enabled = false;
            selectionform.Show();
            this.Hide();
        }
    }
}
