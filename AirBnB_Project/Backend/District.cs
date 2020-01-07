using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnB_Project
{
    class District
    {
        #region attributes

        string name;
        readonly int numNeighbourhoods;
        Neighbourhood[] arrayNeighbourhoods;

        #endregion attributes

        #region constructors

        public District(string inName, Neighbourhood[] inArrayNeighbourhoods)
        {
            name = inName;
            numNeighbourhoods = inArrayNeighbourhoods.Length;
            arrayNeighbourhoods = inArrayNeighbourhoods;
        }

        #endregion constructors

        #region getters
        public string getName()
        {
            return name;
        }
        public int getNumNeighbourhoods()
        {
            return numNeighbourhoods;
        }
        public Neighbourhood[] getArrayNeighbourhoods()
        {
            return arrayNeighbourhoods;
        }

        #endregion getters

        #region setters
        public void setName(string inName)
        {
            name = inName;
        }
        public void setArrayNeighbourhoods(Neighbourhood[] inArrayNeighbourhoods)
        {
            arrayNeighbourhoods = inArrayNeighbourhoods;
        }

        #endregion setters
    }
}
