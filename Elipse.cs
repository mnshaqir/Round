using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round
{
    internal class Elipse
    {
        //data
        private double _majorRad;
        private double _minorRad;

        public double MajorRad
        {
            get { return _majorRad; }
            set { _majorRad = value; }
        }

        public double MinorRad
        {
            get { return _minorRad; }
            set { _minorRad = value; }
        }

        //constructor
        public Elipse()
        {
            _majorRad = 0;
            _minorRad = 0;
        }


        public double Area()
        {
            return Math.PI * _majorRad * _minorRad;
        }

        public double Circumference()
        {
            return Math.PI * (_majorRad + _minorRad);
        }
    }
}
