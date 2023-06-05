using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoddyBox4
{
    class Cylinder
    {
        private double height;
        private double radius;

        public Cylinder()
        {
            this.Radius = 1.0;
            this.Height = 1.0;
        }
        public Cylinder(double r, double h)
        {
            this.Radius = r;
            this.Height = h;
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double getVolume()
        {
            return (Math.Round(Math.Sqrt(radius) * Math.PI * height,2));
        }
    }
}
