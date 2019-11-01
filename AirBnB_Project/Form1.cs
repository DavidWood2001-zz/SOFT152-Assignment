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
    public partial class Main : Form
    {
        Control edit = new editForm();
        Control search = new searchForm();
        
        public Main()
        {
            InitializeComponent();
            panel1.Controls.Add(search);
            panel1.Controls.Add(edit);
            edit.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //when the edit button is pressed the edit form pops up
            edit.BringToFront();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //when the add button is pressed the add form pops up
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //when the search button is pressed the search form pops up
            
            search.BringToFront();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //when the delete button is pressed the delete form pops up
        }
    }
}
