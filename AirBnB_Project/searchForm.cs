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
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Code to search for a property
            doesntWork();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }

        public void doesntWork()
        {
            InitializeComponent();
            MessageBox.Show("This button does not work yet", "Important", MessageBoxButtons.OK);
        }
    }
}
