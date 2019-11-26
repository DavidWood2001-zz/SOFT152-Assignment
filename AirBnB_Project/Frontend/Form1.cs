using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fileControls;

namespace AirBnB_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        { 
            Application.Exit();
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            FileControls.UploadFile_DragEnter(e);
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            FileControls.UploadFile_DragDrop();
        }

        private void lblLoadFile_Click(object sender, EventArgs e)
        {
            FileControls.processFileLoad(openFileDialog1);
        }

        private void PicBoxLoadFile_Click(object sender, EventArgs e)
        {
            FileControls.processFileLoad(openFileDialog1);
        }

        private void PicBoxLoadFile2_Click(object sender, EventArgs e)
        {
            FileControls.processFileLoad(openFileDialog1);
        }
    }
}
