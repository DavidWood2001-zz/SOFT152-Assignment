using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBnB_Project
{
    public partial class editForm: UserControl
    {
        public editForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Code to search for a property
            searchFunction();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Code to add a property
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //Code to edit a property
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "Enter a property name")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_EnterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchFunction();
            }
        }
        private void PicSearch_Click(object sender, EventArgs e)
        {
            searchFunction();
        }

        public void searchFunction()
        {
            //Code to search for a property
            Console.Beep();
        }
    }
}
