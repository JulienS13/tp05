using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract public class Figure
    {
        double x;
        double y;


        public Figure(double x = 1, double y = 1)
        {
            this.x = x;
            this.y = y;
        }

        abstract public double Surface();       


        public string Informations()
        {
            return x + " " + y;
        }
    }


}
