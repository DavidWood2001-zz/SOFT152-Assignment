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
        #region variables
        private int selectedDistrict;
        private int selectedNeighbourhood = 0;
        private int selectedProperty = 0;
        private District[] lstDistricts;
        private int[] propertyCoords = new int[2];
        private int[,] listOfPropsCoords;
        private int propertyIndex = 0;
        private string localFilePath;

        #endregion variables
        public Main()
        {
            InitializeComponent();
        }

        #region formEvents
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
        #endregion formEvents

        #region loadFile
        private static void Main_DragEnter(object sender, DragEventArgs e)
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
            localFilePath = filePath;
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

        #region setInformation

        private void LstBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDistrict = lstBoxDistrict.SelectedIndex;
            selectedNeighbourhood = 0;
            selectedProperty = 0;
            propertyIndex = 0;
            if (lstBoxNeighbourhood.Items != null)
            {
                setNeighbourhoodBox();
                setPropertyBox();
            }
        }

        private void LstBoxNeighbourhood_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNeighbourhood = lstBoxNeighbourhood.SelectedIndex;
            selectedProperty = 0;
            propertyIndex = 0;
            if (lstBoxProperty.Items != null)
            {
                setPropertyBox();
            }
        }

        private void LstBoxProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProperty = lstBoxProperty.SelectedIndex;
            mapBox.Invalidate();
            setPropertyInfo();
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
            try
            {
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
            catch
            {
            }
        }
        private void setPropertyBox()
        {
            //SET THE LIST BOX
            //Clear the list box
            lstBoxProperty.Items.Clear();
            // Get the Neighbourhood array
            try
            {
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
                if (selectedPropertyArray.Length != 0)
                {
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
                }
            }
            catch
            {
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
            try
            {
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
            catch
            {
                txtPropID.Text = "";
                txtPropName.Text = "";
                txtHostID.Text = "";
                txtHostName.Text = "";
                txtNumProps.Text = "";
                txtRoomType.Text = "";
                txtLatitude.Text = "";
                txtLongitude.Text = "";
                txtMinStays.Text = "";
                txtAvailability.Text = "";
                txtPrice.Text = "";
            }
        }
        #endregion setInformation

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

        #region addClick
        private void BtnAddDistrict_Click(object sender, EventArgs e)
        {
            //Add a district
            add("District", txtDistrictName.Text);
        }

        private void BtnAddNeighbourhood_Click(object sender, EventArgs e)
        {
            //Add a neighbourhood
            add("Neighbourhood", txtNeighbourhoodName.Text);
        }

        private void BtnAddProperty_Click(object sender, EventArgs e)
        {
            //Add a property
            add("Property", txtPropName.Text);
        }

        private void add(string category, string name)
        {
            if (category == "District")
            {
                lstBoxDistrict.Items.Add(txtDistrictName.Text);
                //Create district
                District district = new District(name, new Neighbourhood[0]);
                //Add to district list
                Array.Resize(ref lstDistricts, lstDistricts.Length + 1);
                lstDistricts[lstDistricts.Length - 2] = district;
            }
            else if (category == "Neighbourhood") {
                lstBoxNeighbourhood.Items.Add(txtNeighbourhoodName.Text);
                //Create neighbourhood
                //Add to neighbourhood list
                Neighbourhood[] lstNeighbourhoods = lstDistricts[selectedDistrict].getArrayNeighbourhoods();
                Array.Resize(ref lstNeighbourhoods, lstNeighbourhoods.Length + 1);
                lstNeighbourhoods[lstNeighbourhoods.Length - 1] = new Neighbourhood(name, new Property[0]);
                lstDistricts[selectedDistrict].setArrayNeighbourhoods(lstNeighbourhoods);
            }
            else if (category == "Property")
            {
                lstBoxProperty.Items.Add(txtPropName.Text);
                //Create property
                Neighbourhood[] lstNeighbourhoods = lstDistricts[selectedDistrict].getArrayNeighbourhoods();
                Property[] lstProperties = lstNeighbourhoods[selectedNeighbourhood].getArrayProperties();
                Array.Resize(ref lstProperties, lstProperties.Length + 1);

                Property property = new Property(txtPropID.Text, txtPropName.Text, txtHostID.Text, txtHostName.Text,
                    txtNumProps.Text, txtLatitude.Text, txtLongitude.Text, txtRoomType.Text, txtPrice.Text, txtMinStays.Text,
                    txtAvailability.Text);

                lstProperties[lstProperties.Length - 1] = property;
                lstNeighbourhoods[selectedNeighbourhood].setArrayProperties(lstProperties);
                //Add to property list
                writeFile();
            }
        }
        #endregion addClick

        #region deleteClick
        private void BtnDeleteDistrict_Click(object sender, EventArgs e)
        {
            //Delete the selected District
            //move all elements to the right of that index left by one
            for (int district = selectedDistrict; district < lstDistricts.Length; district++)
            {
                if (lstDistricts.Length - 1 != district)
                {
                    lstDistricts[district] = lstDistricts[district + 1];
                }
                else
                {
                    lstDistricts[district] = null;
                }
            }
            Array.Resize(ref lstDistricts, lstDistricts.Length - 1);
            writeFile();
            setDistrictBox();
        }

        private void BtnDeleteNeighbourhood_Click(object sender, EventArgs e)
            {
            //Delete the selected Neighbourhood
            //move all elements to the right of that index left by one
            Neighbourhood[] lstOfNeighbourhoods = lstDistricts[selectedDistrict].getArrayNeighbourhoods();
            for (int neighbourhood = selectedNeighbourhood; neighbourhood < lstOfNeighbourhoods.Length; neighbourhood++)
            {
                if (lstOfNeighbourhoods.Length - 1 != neighbourhood)
                {
                    lstOfNeighbourhoods[neighbourhood] = lstOfNeighbourhoods[neighbourhood + 1];
                }
                else
                {
                    lstOfNeighbourhoods[neighbourhood] = null;
                }
            }
            Array.Resize(ref lstOfNeighbourhoods, lstOfNeighbourhoods.Length - 1);
            lstDistricts[selectedDistrict].setArrayNeighbourhoods(lstOfNeighbourhoods);
            writeFile();
            setDistrictBox();
        }

        private void BtnDeleteProperty_Click(object sender, EventArgs e)
        {
            //Delete a property
            Neighbourhood[] lstNeighbourhoods = lstDistricts[selectedDistrict].getArrayNeighbourhoods();
            Property[] lstProperties = lstNeighbourhoods[selectedNeighbourhood].getArrayProperties();
            for (int property = selectedProperty; property < lstProperties.Length; property++)
            {
                if(lstProperties.Length - 1 != property)
                {
                    lstProperties[property] = lstProperties[property + 1];
                }
                else
                {
                    lstProperties[property] = null;
                }
            }
            Array.Resize(ref lstProperties, lstProperties.Length - 1);
            lstNeighbourhoods[selectedDistrict].setArrayProperties(lstProperties);
            writeFile();
            setDistrictBox();
        }
        #endregion deleteClick

        #region editCLick
        private void BtnEditProperty_Click(object sender, EventArgs e)
        {
            //Edit a property
            writeFile();
        }
        #endregion editClick

        #region writeFile
        private void writeFile()
        {
            StreamWriter sw = new StreamWriter(localFilePath);
            for (int district = 0; district < lstDistricts.Length; district++)
            {
                if (lstDistricts[district] != null)
                {
                    sw.WriteLine(lstDistricts[district].getName());
                    sw.WriteLine(lstDistricts[district].getNumNeighbourhoods());
                    Neighbourhood[] lstNeighbourhoods = lstDistricts[district].getArrayNeighbourhoods();
                    for (int neighbourhood = 0; neighbourhood < lstNeighbourhoods.Length; neighbourhood++)
                    {
                        if (lstNeighbourhoods[neighbourhood] != null)
                        {
                            sw.WriteLine(lstNeighbourhoods[neighbourhood].getName());
                            sw.WriteLine(lstNeighbourhoods[neighbourhood].getNumProperties());
                            Property[] lstProperties = lstNeighbourhoods[neighbourhood].getArrayProperties();
                            for (int property = 0; property < lstProperties.Length; property++)
                            {
                                sw.WriteLine(lstProperties[property].getPropertyID());
                                sw.WriteLine(lstProperties[property].getPropertyName());
                                sw.WriteLine(lstProperties[property].getHostID());
                                sw.WriteLine(lstProperties[property].getHostName());
                                sw.WriteLine(lstProperties[property].getNumHostProperties());
                                sw.WriteLine(lstProperties[property].getLatitude());
                                sw.WriteLine(lstProperties[property].getLongitude());
                                sw.WriteLine(lstProperties[property].getRoomType());
                                sw.WriteLine(lstProperties[property].getPrice());
                                sw.WriteLine(lstProperties[property].getMinDays());
                                sw.WriteLine(lstProperties[property].getAvailability());
                            }
                        }
                    }
                }
            }
            sw.Close();
        }
        #endregion writeFile
    }
}


