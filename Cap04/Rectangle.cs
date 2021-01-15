using System;
using System.Globalization;

namespace Cap04
{
    class Rectangle
    {
        public double Width;
        public double Hight;

        public double Area()
        {
            return Width * Hight;
        }

        public double Perimeter()
        {
            return 2 * (Width + Hight);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Hight, 2));
        }

        public override string ToString()
        {
            return "Area: " + Area().ToString("f2", CultureInfo.InvariantCulture) +
                "\nPerimeter: " + Perimeter().ToString("f2", CultureInfo.InvariantCulture) +
                "\nDiagonal: " + Diagonal().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
