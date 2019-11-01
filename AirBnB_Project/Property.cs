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
        private int getPropertyID()
        {
            return propertyID;
        }
        private string getPropertyName()
        {
            return propertyName;
        }
        private int getHostID()
        {
            return hostID;
        }
        private string getHostName()
        {
            return hostName;
        }
        private int getNumHostProperties()
        {
            return numHostProperties;
        }
        private double getLatitude()
        {
            return latitude;
        }
        private double getLongitude()
        {
            return longitude;
        }
        private string getRoomType()
        {
            return roomType;
        }
        private double getPrice()
        {
            return price;
        }
        private int getMinDays()
        {
            return minDays;
        }
        private int getAvailability()
        {
            return availability;
        }
        //SETTERS
        public void setPropertyID(int inPropertyID)
        {
            propertyID = inPropertyID;
        }
        public void setPropertyName(string inPropertyName)
        {
            propertyName = inPropertyName;
        }
        public void setHostID(int inHostID)
        {
            hostID = inHostID;
        }
        public void setHostName(string inHostName)
        {
            hostName = inHostName;
        }
        public void setNumHostProperties(int inHostProperties)
        {
            numHostProperties = inHostProperties;
        }
        public void setLatitude(double inLatitude)
        {
            latitude = inLatitude;
        }
        public void setLongitude(double inLongitude)
        {
            longitude = inLongitude;
        }
        public void setRoomType(string inType)
        {
            roomType = inType;
        }
        public void setPrice(double inPrice)
        {
            price = inPrice;
        }
        public void setMinDays(int inDays)
        {
            minDays = inDays;
        }
        public void setAvailability(int inAvailability)
        {
            availability = inAvailability;
        }
    }
}
