using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBnB_Project
{
    class Property
    {
        // ATTRIBUTES
        string propertyID;
        string propertyName;
        string hostID;
        string hostName;
        string numHostProperties;
        string latitude;
        string longitude;
        string roomType;
        string price;
        string minDays;
        string availability;

        // CONSTRUCTOR
        public Property(string inPropertyID, string inPropertyName, string inHostID, string inHostName, string inHostProperties,
            string inLatitude, string inLongitude, string inType, string inPrice, string inDays, string inAvailabilty)
        {
            propertyID = checkPropertyID(Convert.ToInt32(inPropertyID));
            propertyName = checkPropertyName(inPropertyName);
            hostID = checkHostID(Convert.ToInt32(inHostID));
            hostName = checkHostName(inHostName);
            numHostProperties = checkNumHostProperties(Convert.ToInt32(inHostProperties));
            latitude = checkLatitude(Convert.ToDouble(inLatitude));
            longitude = checkLongitude(Convert.ToDouble(inLongitude));
            roomType = checkRoomType(inType);
            price = checkPrice(Convert.ToDouble(inPrice));
            minDays = checkMinDays(Convert.ToInt32(inDays));
            availability = checkAvailability(Convert.ToInt32(inAvailabilty));
        }

        //GETTERS
        public string getPropertyID()
        {
            return propertyID;
        }
        public string getPropertyName()
        {
            return propertyName;
        }
        public string getHostID()
        {
            return hostID;
        }
        public string getHostName()
        {
            return hostName;
        }
        public string getNumHostProperties()
        {
            return numHostProperties;
        }
        public string getLatitude()
        {
            return latitude;
        }
        public string getLongitude()
        {
            return longitude;
        }
        public string getRoomType()
        {
            return roomType;
        }
        public string getPrice()
        {
            return price;
        }
        public string getMinDays()
        {
            return minDays;
        }
        public string getAvailability()
        {
            return availability;
        }

        //SETTERS
        public void setPropertyID(string inPropertyID)
        {
            propertyID = checkPropertyID(Convert.ToInt32(inPropertyID));

        }
        public void setPropertyName(string inPropertyName)
        {
            propertyName = checkPropertyName(inPropertyName);
        }
        public void setHostID(string inHostID)
        {
            hostID = checkHostID(Convert.ToInt32(inHostID));
        }
        public void setHostName(string inHostName)
        {
            hostName = checkHostName(inHostName);
        }
        public void setNumHostProperties(string inHostProperties)
        {
            numHostProperties = checkNumHostProperties(Convert.ToInt32(inHostProperties));
        }
        public void setLatitude(string inLatitude)
        {
            latitude = checkLatitude(Convert.ToDouble(inLatitude));
        }
        public void setLongitude(string inLongitude)
        {
            longitude = checkLongitude(Convert.ToDouble(inLongitude));
        }
        public void setRoomType(string inType)
        {
            roomType = checkRoomType(inType);
        }
        public void setPrice(string inPrice)
        {
            price = checkPrice(Convert.ToDouble(inPrice));
        }
        public void setMinDays(string inDays)
        {
            minDays = checkMinDays(Convert.ToInt32(inDays));
        }
        public void setAvailability(string inAvailability)
        {
            availability = checkAvailability(Convert.ToInt32(inAvailability));
        }
        //METHODS TO CHECK INPUT
        public static string checkPropertyID(int inPropertyID)
        {
            if (inPropertyID > 0)
            {
                return Convert.ToString(inPropertyID);
            }
            else
            {
                showErrorMessage("The property ID has to be greater than 0");
                return "0";
            }
        }
        public static string checkPropertyName(string inPropertyName)
        {
            if (inPropertyName != "")
            {
                 return inPropertyName;
            }
            else
            {
                showErrorMessage("The properties name cannot be empty");
                return "NOT GIVEN";
            }
        }
        public static string checkHostID(int inHostID)
        {
            if (Convert.ToInt32(inHostID) >= 0)
            {
                return Convert.ToString(inHostID);
            }
            else
            {
                showErrorMessage("The host ID has to be greater than 0");
                return "0";
            }
        }
        public static string checkHostName(string inHostName)
        {
            if (inHostName != "")
            {
                return inHostName;
            }
            else
            {
                showErrorMessage("The host name cannot be empty");
                return string.Format("NOT GIVEN");
            }
        }
        public static string checkNumHostProperties(int inHostProperties)
        {
            if (inHostProperties > 0)
            {
                return Convert.ToString(inHostProperties);
            }
            else
            {
                showErrorMessage("The number of host properties has to be at least 1");
                return "0";
            }
        }
        public static string checkLatitude(double inLatitude)
        {
            if (inLatitude > -90 && inLatitude < 90)
            {
                return Convert.ToString(inLatitude);
            }
            else
            {
                showErrorMessage("Latitude has to be between -90 and 90");
                return "0";
            }
        }
        public static string checkLongitude(double inLongitude)
        {
            if (inLongitude > -180 && inLongitude < 180)
            {
                return Convert.ToString(inLongitude);
            }
            else
            {
                showErrorMessage("Longitude has to be between -180 and 180");
                return "0";
            }
        }
        public static string checkRoomType(string inType)
        {
            try
            {
                return inType;
            }
            catch (Exception e)
            {
                showErrorMessage(e.Message);
                return "NOT GIVEN";
            }
        }
        public static string checkPrice(double inPrice)
        {
            if (inPrice >= 0)
            {
                return Convert.ToString(inPrice);
            }
            else
            {
                showErrorMessage("Price has to be greater than 0");
                return "0";
            }
        }
        public static string checkMinDays(int inDays)
        {
            if (inDays > 0)
            {
                return Convert.ToString(inDays);
            }
            else
            {
                showErrorMessage("Min days has to be greater than 0");
                return "0";
            }
        }
        public static string checkAvailability(int inAvailability)
        {
            if (inAvailability <= 365 && inAvailability >= 0)
            {
                return Convert.ToString(inAvailability);
            }
            else
            {
                showErrorMessage("Availability has to be greater than or equal to 0");
                return "0";
            }
        }
        public static void showErrorMessage(string inMessage)
        {
            //Shows a pop-up error message if a user causes an issue
            MessageBox.Show(inMessage);
        }
    }
}
