﻿using System;
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
            editForm edit = new editForm();
            edit.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addForm add = new addForm();
            add.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchForm search = new searchForm();
            search.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteForm delete = new deleteForm();
            delete.Show();
        }
    }
}