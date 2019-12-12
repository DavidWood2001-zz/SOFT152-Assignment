using System;
using System.Drawing;
using System.Windows.Forms;
using fileControls;
using System.IO;
using GraphicsLibrary;

namespace AirBnB_Project
{
    public partial class Main : Form
    {
        #region attributes
        private int selectedDistrict;
        private int selectedNeighbourhood;
        private int selectedProperty;
        private District[] lstDistricts;
        private int[] propertyCoords = new int[2];
        private int[,] listOfPropsCoords;
        private int propertyIndex;

        #endregion attributes

        #region constructor
        public Main()
        {
            InitializeComponent();
            comboDelete.Items.Add("District");
            comboDelete.Items.Add("Neighbourhood");
            comboDelete.Items.Add("Property");
        }
        #endregion constructor

        #region metthods
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            if (FileControls.processFileLoad(openFileDialog1))
            {
                readFile(openFileDialog1.FileName);
            }
            mapBox.Paint += new PaintEventHandler(this.MapBox_Paint);
        }
        static void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region fileInput
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

        #endregion fileInput

        #region readFile

        private void readFile(string filePath)
        {
            // Clear the property index for the map
            propertyIndex = 0;
            // Create streamreader
            StreamReader sr = new StreamReader(filePath);
            // Set numAttributes (for property) to 11
            int numAttributes = 11;
            //Create array of districts as empty
            lstDistricts = new District[1];
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
                    // Resize array to current size plus 1
                    Array.Resize(ref lstDistricts, lstDistricts.Length + 1);
                    //increment the districts index
                    districtIndex += 1;
                    //End if
                }
                // End while
            }
            sr.Dispose();
            setDistrictBox();
        }

        #endregion readFile

        #region setInfo
        private void LstBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDistrict = lstBoxDistrict.SelectedIndex;
            selectedNeighbourhood = 0;
            selectedProperty = 0;
            propertyIndex = 0;
            setNeighbourhoodBox();
            setPropertyBox();
            setTxtDelete();
        }

        private void LstBoxNeighbourhood_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNeighbourhood = lstBoxNeighbourhood.SelectedIndex;
            selectedProperty = 0;
            propertyIndex = 0;
            setPropertyBox();
            setTxtDelete();
        }

        private void LstBoxProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProperty = lstBoxProperty.SelectedIndex;
            mapBox.Invalidate();
            setPropertyInfo();
            setTxtDelete();
        }

        private void ComboDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            setTxtDelete();
        }

        private void setDistrictBox()
        {
            //SET THE LIST BOX
            // Clear the list box
            lstBoxDistrict.Items.Clear();
            // For district in inLstItems
            for (int district = 0; district < lstDistricts.Length - 1; district++)
            {
                // Get name of item
                string itemName = lstDistricts[district].getName();
                // Add the district to the specified listBox
                lstBoxDistrict.Items.Add(itemName);
            }
            setNeighbourhoodBox();
            setPropertyBox();
        }

        private void setNeighbourhoodBox()
        {
            //SET THE LIST BOX
            //Clear the list box
            lstBoxNeighbourhood.Items.Clear();
            // Get the neighbourhood array
            Neighbourhood[] selectedNeighbourhoodArray = lstDistricts[selectedDistrict].getArrayNeighbourhoods();
            // For neighbourhood in inLstItems
            for (int neighbourhood = 0; neighbourhood < selectedNeighbourhoodArray.Length; neighbourhood++)
            {
                // Get name of item
                string itemName = selectedNeighbourhoodArray[neighbourhood].getName();
                // Add the district to the specified listBox
                lstBoxNeighbourhood.Items.Add(itemName);
            }
        }
        private void setPropertyBox()
        {
            //SET THE LIST BOX
            //Clear the list box
            lstBoxProperty.Items.Clear();
            // Get the Neighbourhood array
            Neighbourhood[] selectedNeighbourhoodArray = lstDistricts[selectedDistrict].getArrayNeighbourhoods();
            // Get the property array from the neighbourhood
            Property[] selectedPropertyArray = selectedNeighbourhoodArray[selectedNeighbourhood].getArrayProperties();
            // Instantiate the array of property co-ords as the length of number of properties
            listOfPropsCoords = new int[selectedNeighbourhoodArray[selectedNeighbourhood].getNumProperties(), 2];
            // Create array for topLeft location
            double[] topLeftArray = new double[2];
            topLeftArray[0] = -74.263301;
            topLeftArray[1] = 40.911288;
            // For district in inLstItems
            for (int property = 0; property < selectedPropertyArray.Length; property++)
            {
                // Get name of item
                string itemName = selectedPropertyArray[property].getPropertyName();
                // Add the district to the specified listBox
                lstBoxProperty.Items.Add(itemName);
                // Create array for property location
                double[] propLongLats = new double[2];
                propLongLats[0] = Convert.ToDouble(selectedPropertyArray[property].getLongitude());
                propLongLats[1] = Convert.ToDouble(selectedPropertyArray[property].getLatitude());

                propertyCoords = G.calculateCoords(topLeftArray, propLongLats, 40.489110, -73.666177, mapBox.Width, mapBox.Height);
                listOfPropsCoords[propertyIndex, 0] = propertyCoords[0];
                listOfPropsCoords[propertyIndex, 1] = propertyCoords[1];
                propertyIndex += 1;
            }
            // Redraw the picture box
            mapBox.Invalidate();
            // Set the property info boxes
            setPropertyInfo();
        }

        private void setPropertyInfo()
        {
            // SET ALL THE TEXT BOXES TO THE RELEVANT INFO
            // Get the selected property
            Neighbourhood[] selectedNeighbourhoodArray = lstDistricts[selectedDistrict].getArrayNeighbourhoods();
            Property[] selectedPropertyArray = selectedNeighbourhoodArray[selectedNeighbourhood].getArrayProperties();
            Property currentProperty = selectedPropertyArray[selectedProperty];
            // Get the attributes and save to temp variables
            string tempPropID = currentProperty.getPropertyID();
            string tempPropName = currentProperty.getPropertyName();
            string tempHostID = currentProperty.getHostID();
            string tempHostName = currentProperty.getHostName();
            string tempNumProps = currentProperty.getNumHostProperties();
            string tempRoomType = currentProperty.getRoomType();
            string tempLatitude = currentProperty.getLatitude();
            string tempLongitude = currentProperty.getLongitude();
            string tempMinStay = currentProperty.getMinDays();
            string tempAvailability = currentProperty.getAvailability();
            string tempPrice = currentProperty.getPrice();
            // set the text attributes of relevant text boxes to the right attribute
            txtPropID.Text = tempPropID;
            txtPropName.Text = tempPropName;
            txtHostID.Text = tempHostID;
            txtHostName.Text = tempHostName;
            txtNumProps.Text = tempNumProps;
            txtRoomType.Text = tempRoomType;
            txtLatitude.Text = tempLatitude;
            txtLongitude.Text = tempLongitude;
            txtMinStays.Text = tempMinStay;
            txtAvailability.Text = tempAvailability;
            txtPrice.Text = tempPrice;
        }

        private void setTxtDelete()
        {
            District curDistrict = lstDistricts[selectedDistrict];
            Neighbourhood[] curNeighbourhoodArray = curDistrict.getArrayNeighbourhoods();
            Neighbourhood curNeighbourhood = curNeighbourhoodArray[selectedNeighbourhood];
            Property[] curPropertyArray = curNeighbourhood.getArrayProperties();
            Property curProperty = curPropertyArray[selectedProperty];
            if (comboDelete.SelectedIndex == 0)
            {
                txtDelete.Text = curDistrict.getName();
            }
            else if (comboDelete.SelectedIndex == 1)
            {
                txtDelete.Text = curNeighbourhood.getName();
            }
            else if (comboDelete.SelectedIndex == 2)
            {
                txtDelete.Text = curProperty.getPropertyName();
            }
        }

        #endregion setInfo

        #region map
        private void MapBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen unselectedPen = new Pen(Color.Red, 10);
            Pen selectedPen = new Pen(Color.Blue, 10);
            if (listOfPropsCoords != null)
            {
                for (int curProperty = 0; curProperty < (listOfPropsCoords.Length/2); curProperty++)
                {
                    if (curProperty == selectedProperty)
                    {
                        g.FillEllipse(selectedPen.Brush, new Rectangle(listOfPropsCoords[curProperty, 0], listOfPropsCoords[curProperty, 1], 5, 5));
                    }
                    else
                    {
                        g.FillEllipse(unselectedPen.Brush, new Rectangle(listOfPropsCoords[curProperty, 0], listOfPropsCoords[curProperty, 1], 5, 5));
                    }
                }
            }
        }
        #endregion map

        #endregion methods
    }
}


