﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine(" Draw a Circle\n");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine(" Draw a Rectangle\n");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine(" Draw a Triangle.\n");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    }
}
