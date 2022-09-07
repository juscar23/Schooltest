using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Class
{
    public class clsRectangle
    {
        private double length, width;
        public double resultP, resultA;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
             set { width = value; }
        }

        public double Perimeter()
        {
            resultP = 2 * (length + width);
            return resultP;
        }
        public double Area()
        {
            resultA = length * width;
            return resultA;
        }

    }
}
