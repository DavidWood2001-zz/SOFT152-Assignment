using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Property(string inpropertyName, int inHostID, string inHostName, int inHostProperties,
            double inLatitude, double inLongitude, string inType, double inPrice, int inDays, int inAvailabilty)
        {
            propertyID = 1;
            propertyName = inpropertyName;
            hostID = inHostID;
            hostName = inHostName;
            numHostProperties = inHostProperties;
            latitude = inLatitude;
            longitude = inLongitude;
            roomType = inType;
            price = inPrice;
            minDays = inDays;
            availability = inAvailabilty;
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
            if (inPropertyID > 0)
            {
                propertyID = inPropertyID;
            }
        }
        public void setPropertyName(string inPropertyName)
        {
            if (inPropertyName != "")
            {
                propertyName = inPropertyName;
            }
        }
        public void setHostID(int inHostID)
        {
            if (hostID > 0)
            {
                hostID = inHostID;
            }
        }
        public void setHostName(string inHostName)
        {
            if (hostName != "")
            {
                hostName = inHostName;
            }
        }
        public void setNumHostProperties(int inHostProperties)
        {
            if (inHostProperties > 0)
            {
                numHostProperties = inHostProperties;
            }
        }
        public void setLatitude(double inLatitude)
        {
            if (inLatitude > 0)
            {
                latitude = inLatitude;
            }
        }
        public void setLongitude(double inLongitude)
        {
            if (inLongitude > 0)
            {
                longitude = inLongitude;
            }
        }
        public void setRoomType(string inType)
        {
            roomType = inType;
        }
        public void setPrice(double inPrice)
        {
            if (inPrice > 0)
            {
                price = inPrice;
            }
        }
        public void setMinDays(int inDays)
        {
            if (inDays > 0)
            {
                minDays = inDays;
            }
        }
        public void setAvailability(int inAvailability)
        {
            if (inAvailability <= 365 && inAvailability > 0)
            {
                availability = inAvailability;
            }
        }
    }
}
