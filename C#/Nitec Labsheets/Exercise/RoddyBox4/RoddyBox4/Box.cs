using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoddyBox4
{
    class Box
    {
        private double length;
        private double breath;
        private double height;
        private double radius;

        public Box()
        {
            this.Length = 1.0;
            this.Breath = 1.0;
            this.Height = 1.0;
        }
        public Box(double l, double b, double h)
        {
            this.Length = l;
            this.Breath = b;
            this.Height = h;
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Breath
        {
            get { return breath; }
            set { breath = value; }
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
            return (length * breath * height);
        }
    }
}
