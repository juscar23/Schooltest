using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Class
{
    public class clsquare
    {
        private double sides;

        public double Perimetersquare, Areasquare;

        public double Sides
        {
            get { return sides; }
            set { sides = value; }
        }



        public double Perimeter()
        {
            Perimetersquare = sides * 4;
            return Perimetersquare;
        }
        public double Area()
        {
            Areasquare = Math.Pow(sides, 2);
            return Areasquare;
        }
        

    }
}
