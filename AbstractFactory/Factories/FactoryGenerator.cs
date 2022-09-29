using Shape.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Factories
{
    public class FactoryGenerator
    {
        public static AbstractFactory getFactory(ShapeStyle shapeStyle)
        {
            switch (shapeStyle)
            {
                case ShapeStyle.DEFAULT:
                    return new ShapeFactory();
                case ShapeStyle.ROUNDED:
                    return new RoundedShapeFactory();
                default:
                    break;
            }

            throw new InvalidEnumArgumentException();
        }
    }
}
