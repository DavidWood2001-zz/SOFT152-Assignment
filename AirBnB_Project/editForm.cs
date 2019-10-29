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
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button does not work yet", "Important", MessageBoxButtons.OK);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }
    }
}
