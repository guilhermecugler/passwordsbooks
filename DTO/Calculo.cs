using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Calculo
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double calcularDistancia(double x1, double y1, double x2, double y2)
        {
            double x = x2 - x1;
            double y = y2 - y1;

            double distancia = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(x, 2));

            return distancia;
        }
       // public double azimute { get; set; }

        public double calcularAzimute(double x1, double y1, double x2, double y2)
        {
            double dx, dy, az;

            dx = x2 - x1;
            dy = y2 - y1;

            if (dy == 0)
            {
                az = 90;
            }
            else
            {
                double result = Math.Atan(dx / dy) * (180 / Math.PI);
                az = result;
            }

            if (dx >= 0 && dy >= 0)
            {
                az = az;
            }
            else if (dx >= 0 && dy <= 0)
            {
                az = az + 180;
            }
            else if (dx <= 0 && dy <= 0)
            {
                az = az + 180;
            }
            else
            {
                az = az + 360;
            }

            return az;

        }
    }


}
