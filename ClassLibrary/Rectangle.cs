using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rectangle : Figure
    {
        double x;
        double y;
        double l;
        double L;
        double surface;


        public Rectangle(double x, double y, double l, double L)
        {
            this.x = x;
            this.y = y;
            this.l = l;
            this.L = L;
        }

        public override double Surface()
        {
            surface = l * L;
            return surface;
        }
    }
}
