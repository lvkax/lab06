using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Pyramid : iSolid
    {
        public double A { get; set; }
        public double H { get; set; }

        public Pyramid(double a, double h) 
        {
            A = a;
            H = h;
        }

        public double GetVolume()
        {
            return (1 / 3.0) * (Math.Pow(A, 2) * H);
        }
    }
}
