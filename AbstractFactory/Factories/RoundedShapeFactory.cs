using Shape.Enums;
using Shape.Interfaces;
using Shape.Shapes.Normal;
using Shape.Shapes.Rounded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Factories
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape getShape(shapeType shapeType)
        {
            switch (shapeType)
            {
                case shapeType.RECTANGLE:
                    return new RoundedRectangle();
                case shapeType.SQUARE:
                    return new RoundedSquare();
                default:
                    throw new ArgumentException();
            }
        }
    }
}

