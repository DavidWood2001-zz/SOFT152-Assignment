using System;
using System.Drawing;

namespace GraphicsLibrary
{
    public class G
    {
        public static int[] calculateCoords(double[] startLongLats, double[] propLongLat, double bottomLeftLat, double topRightLong, int width, int height)
        {
            int propertyX = Convert.ToInt32((width * (startLongLats[0] - propLongLat[0])) / (startLongLats[0] - topRightLong));
            int propertyY = Convert.ToInt32((height * (startLongLats[1] - propLongLat[1])) / (startLongLats[1] - bottomLeftLat));
            int[] propertyCoords = new int[2];
            propertyCoords[0] = propertyX;
            propertyCoords[1] = propertyY;
            return propertyCoords;
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
