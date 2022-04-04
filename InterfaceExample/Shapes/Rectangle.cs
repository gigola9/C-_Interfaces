using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.Shapes
{
    public class Rectangle : Shape
    {
        protected double a;
        protected double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;

            ResultOfArea = a * b;
        }
        public double ResultOfPeriemter { get; set; }
        public double ResultOfArea { get; set; }

        public double perimeter()
        {
            ResultOfPeriemter = (a + b) * 2;
            return ResultOfPeriemter;
        }
    }
}
