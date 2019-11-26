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
using System.IO;

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
            string filePath = FileControls.UploadFile_DragDrop();
            if (filePath != "")
            {
                readFile(filePath);
            }
        }

        private void lblLoadFile_Click(object sender, EventArgs e)
        {
            if (FileControls.processFileLoad(openFileDialog1))
            {
                readFile(openFileDialog1.FileName);
            }
        }

        private void PicBoxLoadFile_Click(object sender, EventArgs e)
        {
            if (FileControls.processFileLoad(openFileDialog1))
            {
                readFile(openFileDialog1.FileName);
            }
        }

        private void PicBoxLoadFile2_Click(object sender, EventArgs e)
        {
            if (FileControls.processFileLoad(openFileDialog1))
            {
                readFile(openFileDialog1.FileName);
            }
        }

        private void readFile(string filePath)
        {
            // Create streamreader
            StreamReader sr = new StreamReader(filePath);
            // Set numAttributes (for property) to 11
            int numAttributes = 11;
            //Create array of districts as empty
            District[] lstDistricts = new District[1];
            // Set first districts index
            int districtIndex = 0;
            // While not the end of the file
            while (sr.EndOfStream == false)
            {
                // Stores the value of the first line to check if it's empty
                string firstline = sr.ReadLine();
                // If firstline isn't blank
                if (firstline != "")
                {
                    // Assign district name to readline
                    string districtName = firstline;
                    // Assign numNeighbourhoods to readline
                    int numNeighbourhoods = Convert.ToInt32(sr.ReadLine());
                    // Create neighbourhood array with length numNeighbourhoods
                    Neighbourhood[] lstNeighbourhoods = new Neighbourhood[numNeighbourhoods];
                    // For numNeighbourhoods with variable neighbourhood as the increment
                    for (int neighbourhood = 0; neighbourhood < numNeighbourhoods; neighbourhood++)
                    {
                        // Create array propAttributes with length numAttributes
                        string[] propAttributes = new string[numAttributes];
                        // Set neighbourhood name as readline
                        string neighbourhoodName = sr.ReadLine();
                        // Set numProperties as readline
                        int numProperties = Convert.ToInt32(sr.ReadLine());
                        // Create property array with length numProperties
                        Property[] lstProperties = new Property[numProperties];
                        // For numProperties with variable property as the increment
                        for (int property = 0; property < numProperties; property++)
                        {
                            // For numAttributes with variable attribute as the increment
                            for (int attribute = 0; attribute < numAttributes; attribute++)
                            {
                                // set propAttributes[attribute] to readline
                                propAttributes[attribute] = sr.ReadLine();
                                // Next attribute
                            }
                            // Create property object using the propAttributes array and add to property array
                            lstProperties[property] = new Property(propAttributes[0], propAttributes[1], propAttributes[2], propAttributes[3],
                                propAttributes[4], propAttributes[5], propAttributes[6], propAttributes[7], propAttributes[8], propAttributes[9],
                                propAttributes[10]);
                            // DEBUG 
                            //MessageBox.Show(Convert.ToString(lstProperties[property]));
                            // Next property
                        }
                        // Create neighbourhood object using name, numProperties and the property array
                        // And add it to the neighbourhood array
                        lstNeighbourhoods[neighbourhood] = new Neighbourhood(neighbourhoodName, lstProperties);
                        // Next neighbourhood
                    }
                    // Create district object using district name, numNeighbourhoods and the neighbourhood array
                    // And add to the district array
                    lstDistricts[districtIndex] = new District(districtName, lstNeighbourhoods);
                    // DEBUG
                    MessageBox.Show(lstDistricts[districtIndex].getName()); ;
                    // Resize array to current size plus 1
                    Array.Resize(ref lstDistricts, lstDistricts.Length + 1);
                    //increment the districts index
                    districtIndex += 1;
                    //End if
                }

                // End while
            }
        }
    }
}
