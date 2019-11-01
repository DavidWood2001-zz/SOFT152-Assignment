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

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Code to search for a property
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Code to add a property
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //Code to edit a property
        }
    }
}
