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
        int propertyID;
        string propertyName;
        int hostID;
        string hostName;
        int numHostProperties;
        double latitude;
        double longitude;
        string roomType;
        double price;
        int minDays;
        int availability;

        public Property(string inPropertyName, int inHostID, string inHostName, int inHostProperties,
            double inLatitude, double inLongitude, string inType, double inPrice, int inDays, int inAvailabilty)
        {
            propertyID = checkPropertyID(1);
            propertyName = checkPropertyName(inPropertyName);
            hostID = checkHostID(inHostID);
            hostName = checkHostName(inHostName);
            numHostProperties = checkNumHostProperties(inHostProperties);
            latitude = checkLatitude(inLatitude);
            longitude = checkLongitude(inLongitude);
            roomType = checkRoomType(inType);
            price = checkPrice(inPrice);
            minDays = checkMinDays(inDays);
            availability = checkAvailability(inAvailabilty);
        }
        //GETTERS
        public int getPropertyID()
        {
            return propertyID;
        }
        public string getPropertyName()
        {
            return propertyName;
        }
        public int getHostID()
        {
            return hostID;
        }
        public string getHostName()
        {
            return hostName;
        }
        public int getNumHostProperties()
        {
            return numHostProperties;
        }
        public double getLatitude()
        {
            return latitude;
        }
        public double getLongitude()
        {
            return longitude;
        }
        public string getRoomType()
        {
            return roomType;
        }
        public double getPrice()
        {
            return price;
        }
        public int getMinDays()
        {
            return minDays;
        }
        public int getAvailability()
        {
            return availability;
        }
        //SETTERS
        public void setPropertyID(int inPropertyID)
        {
            propertyID = checkPropertyID(inPropertyID);
        }
        public void setPropertyName(string inPropertyName)
        {
            propertyName = checkPropertyName(inPropertyName);
        }
        public void setHostID(int inHostID)
        {
            hostID = checkHostID(inHostID);
        }
        public void setHostName(string inHostName)
        {
            hostName = checkHostName(inHostName);
        }
        public void setNumHostProperties(int inHostProperties)
        {
            numHostProperties = checkNumHostProperties(inHostProperties);
        }
        public void setLatitude(double inLatitude)
        {
            latitude = checkLatitude(inLatitude);
        }
        public void setLongitude(double inLongitude)
        {
            longitude = checkLongitude(inLongitude);
        }
        public void setRoomType(string inType)
        {
            roomType = checkRoomType(inType);
        }
        public void setPrice(double inPrice)
        {
            price = checkPrice(inPrice);
        }
        public void setMinDays(int inDays)
        {
            minDays = checkMinDays(inDays);
        }
        public void setAvailability(int inAvailability)
        {
            availability = checkAvailability(inAvailability);
        }
        //METHODS TO CHECK INPUT
        public int checkPropertyID(int inPropertyID)
        {
            if (inPropertyID > 0)
            {
                return inPropertyID;
            }
            else
            {
                doErrorMessage("The property ID has to be greater than 0");
                return 0;
            }
        }
        public string checkPropertyName(string inPropertyName)
        {
            if (inPropertyName != "")
            {
                 return inPropertyName;
            }
            else
            {
                doErrorMessage("The properties name cannot be empty");
                return string.Format("NOT GIVEN");
            }
        }
        public int checkHostID(int inHostID)
        {
            if (hostID > 0)
            {
                return inHostID;
            }
            else
            {
                doErrorMessage("The host ID has to be greater than 0");
                return 0;
            }
        }
        public string checkHostName(string inHostName)
        {
            if (hostName != "")
            {
                return inHostName;
            }
            else
            {
                doErrorMessage("The host name cannot be empty");
                return string.Format("NOT GIVEN");
            }
        }
        public int checkNumHostProperties(int inHostProperties)
        {
            if (inHostProperties > 0)
            {
                return inHostProperties;
            }
            else
            {
                doErrorMessage("The number of host properties has to be at least 1");
                return 0;
            }
        }
        public double checkLatitude(double inLatitude)
        {
            if (inLatitude > 0)
            {
                return inLatitude;
            }
            else
            {
                doErrorMessage("Latitude has to be greater than 0");
                return 0;
            }
        }
        public double checkLongitude(double inLongitude)
        {
            if (inLongitude > 0)
            {
                return inLongitude;
            }
            else
            {
                doErrorMessage("Longitude has to be greater than 0");
                return 0;
            }
        }
        public string checkRoomType(string inType)
        {
            try
            {
                return inType;
            }
            catch (Exception e)
            {
                doErrorMessage(e.Message);
                return string.Format("NOT GIVEN");
            }
        }
        public double checkPrice(double inPrice)
        {
            if (inPrice > 0)
            {
                return inPrice;
            }
            else
            {
                doErrorMessage("Price has to be greater than 0");
                return 0;
            }
        }
        public int checkMinDays(int inDays)
        {
            if (inDays > 0)
            {
                return inDays;
            }
            else
            {
                doErrorMessage("Min days has to be greater than 0");
                return 0;
            }
        }
        public int checkAvailability(int inAvailability)
        {
            if (inAvailability <= 365 && inAvailability > 0)
            {
                return inAvailability;
            }
            else
            {
                doErrorMessage("Availability has to be inside of the range 0-365");
                return 0;
            }
        }
        public void doErrorMessage(string inMessage)
        {
            //Shows a pop-up error message if a user causes an issue
            MessageBox.Show(inMessage);
        }
    }
}
