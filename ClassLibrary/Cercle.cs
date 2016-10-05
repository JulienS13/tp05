using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cercle : Figure
    {
        double x;
        double y;
        double r;
        double surface;

        public Cercle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public override double Surface()
        {
            surface = Math.PI * Math.Pow(r, 2);
            return surface;
        }
    }
}
