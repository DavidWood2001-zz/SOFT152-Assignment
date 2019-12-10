using System;
using System.IO;
using System.Windows.Forms;

namespace fileControls
{
    public static class FileControls
    {
        public static readonly string[] files;

        private static bool checkFilePath(string filePath)
        {
            try
            {
                string text = filePath;
                int size = text.Length;
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
                string files = Convert.ToString((string[])e.Data.GetData(DataFormats.FileDrop));
            }
        }

        public static string UploadFile_DragDrop()
        {
            if (files.Length > 1)
            {
                MessageBox.Show("You cannot drag and drop more than one file at a time.");
                return "";
            }

            else
            {
                bool fileCorrect = checkFilePath(files[0]);
                if (fileCorrect)
                {
                    return files[0];
                }
                else
                {
                    return "";
                }
            }
        }
        public static bool processFileLoad(OpenFileDialog fileDialog)
        {
            fileDialog.InitialDirectory = "../../..";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an issue loading in your file", "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
