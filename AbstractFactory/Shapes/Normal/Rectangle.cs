﻿using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Shapes.Normal
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.Write("CONSTRUCTION D'UN RECTANGLE");
        }
    }
}
