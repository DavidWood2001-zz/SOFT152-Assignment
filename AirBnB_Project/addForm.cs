using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBnB_Project
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void menuButton_click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Code to add a record
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Code to exit the program
        }
    }
}
