using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnB_Project
{
    class Neighbourhood
    {
        #region attributes

        string name;
        readonly int numProperties;
        Property[] arrayProperties;

        #endregion attributes

        #region constructors
        public Neighbourhood(string inName, Property[] inArrayProperties)
        {
            name = inName;
            numProperties = inArrayProperties.Length;
            arrayProperties = inArrayProperties;
        }

        #endregion constructors

        #region getters
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

        #endregion getters

        #region setters

        public void setName(string inName)
        {
            name = inName;
        }
        public void setArrayProperties(Property[] inArrayProperties)
        {
            Array.Resize(ref arrayProperties, inArrayProperties.Length);
            arrayProperties = inArrayProperties;
        }

        #endregion setters
    }
}
