using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Class
{
    public class clsCircle
    {
        private double radius;

        public double sqArea, sqCircum;

        public double Radius
        {
            get { return radius; }
            set {radius = value;}
        }
        public double Area()
        {
            sqArea = Math.PI * Math.Pow(radius, 2);
            return sqArea;
        }
        public double Circumference()
        {
            sqCircum = 2 * Math.PI * radius;
            return sqCircum;
        }
    }
}
