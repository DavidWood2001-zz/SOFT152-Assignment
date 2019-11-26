using System;
using System.IO;
using System.Windows.Forms;

namespace fileControls
{
    public static class FileControls
    {
        public static string[] files;

        public static void ReadFile(string filePath)
        {
            MessageBox.Show(filePath);
            StreamReader readFile = new StreamReader(filePath);
            while (readFile.EndOfStream == false)
            {
                readFile.ReadLine();
            }
            readFile.Close();
            MessageBox.Show("File Loaded");
        }

        private static bool checkFilePath(string filePath, int size)
        {
            try
            {
                string text = filePath;
                size = text.Length;
                return true;
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Error", "There was an errror with reading the file", MessageBoxButtons.OK);
                return false;
            }
        }

        public static void UploadFile_DragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                files = (string[])e.Data.GetData(DataFormats.FileDrop);
            }
        }

        public static void UploadFile_DragDrop()
        {
            if (files.Length > 1)
            {
                MessageBox.Show("You cannot drag and drop more than one file at a time.");
            }

            else
            {
                bool fileCorrect = checkFilePath(files[0], files.Length);
                if (fileCorrect)
                {
                    ReadFile(files[0]);
                }
            }
        }
        public static void processFileLoad(OpenFileDialog fileDialog)
        {
            fileDialog.InitialDirectory = "C:\\Users\\dwood6\\OneDrive - University of Plymouth\\SOFT152\\Assignment";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileControls.ReadFile(fileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an issue loading in your file", "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
