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
        editForm edit = new editForm();
        deleteForm delete = new deleteForm();
        addForm add = new addForm();
        searchForm search = new searchForm();

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
            if (edit == null)
            {
                edit = new editForm();   //Create form if not created
                edit.FormClosed += edit_FormClosed;  //Add eventhandler to cleanup after form closes
            }

            edit.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //when the add button is pressed the add form pops up
            if (add == null)
            {
                add = new addForm();   //Create form if not created
                add.FormClosed += add_FormClosed;  //Add eventhandler to cleanup after form closes
            }

            add.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //when the search button is pressed the search form pops up
            if (search == null)
            {
                search = new searchForm();   //Create form if not created
                search.FormClosed += search_FormClosed;  //Add eventhandler to cleanup after form closes
            }

            search.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //when the delete button is pressed the search form pops up
            if (delete == null)
            {
                delete = new deleteForm();   //Create form if not created
                edit.FormClosed += delete_FormClosed;  //Add eventhandler to cleanup after form closes
            }

            delete.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        void edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            edit = null;  //If form is closed make sure reference is set to null
            Show();
        }

        void add_FormClosed(object sender, FormClosedEventArgs e)
        {
            add = null;  //If form is closed make sure reference is set to null
            Show();
        }

        void search_FormClosed(object sender, FormClosedEventArgs e)
        {
            search = null;  //If form is closed make sure reference is set to null
            Show();
        }

        void delete_FormClosed(object sender, FormClosedEventArgs e)
        {
            delete = null;  //If form is closed make sure reference is set to null
            Show();
        }
    }
}
