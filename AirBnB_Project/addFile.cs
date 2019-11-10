using System;
using System.IO;
using System.Windows.Forms;

namespace AirBnB_Project
{
    public partial class addFile : UserControl
    {
        public addFile()
        {
            InitializeComponent();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (System.IO.IOException)
                {
                    string msg =
                        "There was an issue with reading the file contents. " +
                        "\nYour current system may not support this type of file access: 'FileDialog'";
                    MessageBox.Show("Oopsie Whoopsy",msg, MessageBoxButtons.OK);
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }
    }
}