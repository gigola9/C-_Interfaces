﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.Shapes
{
    public class Square : Shape
    {
        protected double a;

        public Square(double a)
        {
            this.a = a;

            ResultOfArea = a * a;
        }
        public double ResultOfPeriemter { get; set; }
        public double ResultOfArea { get; set; }

        public double perimeter()
        {
            ResultOfPeriemter = a * 4;
            return ResultOfPeriemter;
        }
    }
}
