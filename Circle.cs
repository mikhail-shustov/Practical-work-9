using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Радиус должен быть больше 0");
                }
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public void GetArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Площадь круга: {area:F0}");
        }
    }
}
