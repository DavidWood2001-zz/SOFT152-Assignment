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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //when the edit button is pressed the edit form pops up
            editForm edit = new editForm();
            edit.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //when the add button is pressed the add form pops up
            addForm add = new addForm();
            add.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //when the search button is pressed the search form pops up
            searchForm search = new searchForm();
            search.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //when the delete button is pressed the search form pops up
            deleteForm delete = new deleteForm();
            delete.Show();
        }
    }
}
