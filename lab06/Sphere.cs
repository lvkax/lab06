using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Sphere : iSolid
    {
        public double R {  get; set; }

        public Sphere(double r)
        {
            R = r;
        }

        public double GetVolume()
        {
            double vol = (4/3.0)*Math.Pow(R, 3);
            return vol;
        }
    }
}
