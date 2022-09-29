using Shape.Enums;
using Shape.Interfaces;
using Shape.Shapes.Normal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Factories
{
    public class ShapeFactory : AbstractFactory
    {
        public override IUsineVelo getShape(VeloMarque shapeType)
        {
            switch (shapeType)
            {
                case shapeType.RECTANGLE:
                    return new Rectangle();
                case shapeType.SQUARE:
                    return new Square();
                default:
                    throw new ArgumentException();
            }
        }
    }
}

