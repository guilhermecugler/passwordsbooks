using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Calculo
    {
        public double latitude1 { get; set; }
        public double longitude1 { get; set; }
        public double latitude2 { get; set; }
        public double longitude2 { get; set; }
        public double calculateDistanceBetween2Points(double latitude1, double longitude1, double latitude2, double longitude2)
        {
            double latitude = latitude2 - latitude1;
            double longitude = longitude2 - longitude1;

            double distance = Math.Sqrt(Math.Pow(longitude, 2) + Math.Pow(latitude, 2));

            return distance;
        }

        public double calculateAzimuth(double latitude1, double longitude1, double latitude2, double longitude2)
        {

            double azimuth;

            double distanceLatitude = latitude2 - latitude1;
            double distanceLongitude = longitude2 - longitude1;

            if (distanceLongitude == 0)
            {
                azimuth = 90;
            }
            else
            {
                double result = Math.Atan(distanceLatitude / distanceLongitude) * (180 / Math.PI);
                azimuth = result;
            }

            if (distanceLatitude >= 0 && distanceLongitude >= 0)
            {
                #pragma warning disable CS1717 // Atribuição feita à mesma variável
                azimuth = azimuth;
                #pragma warning restore CS1717 // Atribuição feita à mesma variável
            }
            else if (distanceLatitude >= 0 && distanceLongitude <= 0)
            {
                azimuth = azimuth + 180;
            }
            else if (distanceLatitude <= 0 && distanceLongitude <= 0)
            {
                azimuth = azimuth + 180;
            }
            else
            {
                azimuth = azimuth + 360;
            }

            return azimuth;

        }
    }


}
