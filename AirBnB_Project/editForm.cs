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

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
                txtSearch.Text = "";
        }

        private void txtSearch_EnterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chooseSearchFunction();
            }
        }
        private void PicSearch_Click(object sender, EventArgs e)
        {
            chooseSearchFunction();
        }

        private void SearchSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchSelection.Text == "District")
            {
                txtSearch.Text = "Enter a district name";
            }
            else if (searchSelection.Text == "Neighbourhood")
            {
                txtSearch.Text = "Enter a neighbourhood name";
            }
            else
            {
                txtSearch.Text = "Enter a property name";
            }
        }
        public void chooseSearchFunction()
        {
            string message;
            //Code to search for a property
            if (searchSelection.Text == "District")
            {
                message = searchDistrict();
            }
            else if (searchSelection.Text == "Neighbourhood")
            {
                message = searchNeighbourhood();
            }
            else
            {
                message = searchProperty();
            }
            MessageBox.Show(message);
        }

        public string searchDistrict()
        {
            //Code to search through districts
            return string.Format("Searching districts");
        }
        public string searchNeighbourhood()
        {
            //Code to search through neighbourhoods
            return string.Format("Searching neighbourhoods");
        }
        public string searchProperty()
        {
            //Code to search through properties
            return string.Format("Searching properties");
        }
    }
}
