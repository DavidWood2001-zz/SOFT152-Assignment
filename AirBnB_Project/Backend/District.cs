using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnB_Project
{
    class District
    {
        //ATTRIBUTES
        string name;
        readonly int numNeighbourhoods;
        Neighbourhood[] arrayNeighbourhoods;

        //CONTRUCTOR
        public District(string inName, Neighbourhood[] inArrayNeighbourhoods)
        {
            name = inName;
            numNeighbourhoods = inArrayNeighbourhoods.Length;
            arrayNeighbourhoods = inArrayNeighbourhoods;
        }

        //GETTERS
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

        //SETTERS
        public void setName(string inName)
        {
            name = inName;
        }
        public void setArrayNeighbourhoods(Neighbourhood[] inArrayNeighbourhoods)
        {
            arrayNeighbourhoods = inArrayNeighbourhoods;
        }
    }
}
