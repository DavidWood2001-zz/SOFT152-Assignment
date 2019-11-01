using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBnB_Project
{
    public partial class editForm: UserControl
    {
        public editForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Code to search for a property
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Code to add a property
            int propertyID = Convert.ToInt32(propertyTable[0, 0].Value);
            string propertyName = Convert.ToString(propertyTable[1, 0].Value);
            int hostID = Convert.ToInt32(propertyTable[2, 0].Value);
            string hostName = Convert.ToString(propertyTable[3, 0].Value);
            int numProperties = Convert.ToInt32(propertyTable[4, 0].Value);
            double latitude = Convert.ToDouble(propertyTable[5, 0].Value);
            double longitude = Convert.ToDouble(propertyTable[6, 0].Value);
            string roomType = Convert.ToString(propertyTable[7, 0].Value);
            double price = Convert.ToDouble(propertyTable[8, 0].Value);
            int minDays = Convert.ToInt32(propertyTable[9, 0].Value);
            int availability = Convert.ToInt32(propertyTable[10, 0].Value);
            if (propertyID == 0 || hostID == 0 || numProperties == 0 || minDays == 0 || availability == 0
                || latitude == 0 || longitude == 0 || price == 0)
            {
                propertyTable.Rows.RemoveAt(this.propertyTable.Rows[0].Index);
            }
            else if (propertyName == "" || hostName == "" || roomType == "")
            {
                propertyTable.Rows.RemoveAt(this.propertyTable.Rows[0].Index);
            }
            else
            {
                Property firstProperty = new Property(propertyID, propertyName, hostID, hostName, numProperties,
                    latitude, longitude, roomType, price, minDays, availability);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //Code to edit a property
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
