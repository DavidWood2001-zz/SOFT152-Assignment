using System;
using System.Drawing;

namespace GraphicsLibrary
{
    public class G
    {
        public static int[] calculateCoords(double[] startLongLats, double[] propLongLat, double bottomLeftLat, double topRightLong, int width, int height)
        {
            double xUnit = (topRightLong - startLongLats[0]) / width;
            double yUnit = (bottomLeftLat - startLongLats[1]) / width;
            int propX = Convert.ToInt32(propLongLat[0] * xUnit);
            int propY = Convert.ToInt32(propLongLat[1] * yUnit);
            int[] propCoords = new int[2];
            propCoords[0] = propX;
            propCoords[1] = propY;
            return propCoords;
        }

        public static int[] extDrawLine(int[] currentCoords, int[] endCoords)
        {
            currentCoords[0] = CheckCoords(currentCoords[0], endCoords[0]);
            currentCoords[1] = CheckCoords(currentCoords[1], endCoords[1]);
            return currentCoords;
        }

        private static int CheckCoords(int inCoord, int endCoord) {
            if (inCoord != endCoord) {
                if (inCoord < endCoord) {

                    inCoord += 1;
                }
                else {
                    inCoord -= 1;
                }
            }
            return inCoord;
        }
    }
}
