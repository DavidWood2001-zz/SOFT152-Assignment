using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnB_Project
{
    class Neighbourhood
    {
        //ATTRIBUTES
        string name;
        int numProperties;
        Property[] arrayProperties;

        //CONSTRUCTOR
        public Neighbourhood(string inName, Property[] inArrayProperties)
        {
            name = inName;
            numProperties = inArrayProperties.Length;
            arrayProperties = inArrayProperties;
        }

        //GETTERS
        public string getName()
        {
            return name;
        }
        public int getNumProperties()
        {
            return numProperties;
        }
        public Property[] getArrayProperties()
        {
            return arrayProperties;
        }
        //SETTERS
        public void setName(string inName)
        {
            name = inName;
        }
        public void setArrayProperties(Property[] inArrayProperties)
        {
            arrayProperties = inArrayProperties;
        }
    }
}
