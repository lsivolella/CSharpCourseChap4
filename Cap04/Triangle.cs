using System;

namespace Cap04
{
    class Triangle
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double _p = (A + B + C) / 2.0;
            double _area = Math.Sqrt(_p * (_p - A) * (_p - B) * (_p - C));
            return _area;
        }

        public double Area(double A, double B, double C)
        {
            double _p = (A + B + C) / 2.0;
            double _area = Math.Sqrt(_p * (_p - A) * (_p - B) * (_p - C));
            return _area;
        }
    }
}
