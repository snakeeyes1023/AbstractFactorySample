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
        public static AbstractFactory getUsineVelo(VeloType shapeStyle)
        {
            switch (shapeStyle)
            {
                case VeloType.DEFAULT:
                    return new ShapeFactory();
                case VeloType.ROUNDED:
                    return new RoundedShapeFactory();
                default:
                    break;
            }

            throw new InvalidEnumArgumentException();
        }
    }
}
